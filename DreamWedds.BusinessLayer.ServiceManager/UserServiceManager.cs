﻿using AutoMapper;
using DreamWedds.CommonLayer.Application.DTO;
using DreamWedds.CommonLayer.Application.Interfaces;
using DreamWedds.PersistenceLayer.Entities.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using DreamWedds.CommonLayer.Aspects.Security;
using DreamWedds.CommonLayer.Aspects.Utitlities;
using DreamWedds.PersistenceLayer.Repository.PersistenceServices;

namespace DreamWedds.BusinessLayer.ServiceManager
{
    public class UserServiceManager : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserServiceManager(IUserRepository userPersistenceService, IMapper mapper)
        {
            _mapper = mapper;
            _userRepository = userPersistenceService;
        }
        public async Task<UserMasterDto> GetUserAsync(int id)
        {
            var user = await _userRepository.GetUserAsync(id);
            return _mapper.Map<UserMaster, UserMasterDto>(user);
        }

        public async Task<UserMasterDto> AuthenticateUser(string userName, string password)
        {
            userName = EncryptionEngine.EncryptString(userName);
            password = EncryptionEngine.EncryptString(password);
            var user = await _userRepository.AuthenticateUser(userName, password);
            return _mapper.Map<UserMaster, UserMasterDto>(user);
        }
        public async Task<List<UserMasterDto>> GetAllUsers()
        {
            var user = await _userRepository.GetAllUsers();
            return _mapper.Map<IReadOnlyList<UserMaster>, List<UserMasterDto>>(user);
        }

        public async Task<int> AddNewUserAsync(UserMasterDto userDto)
        {
            var user = _mapper.Map<UserMasterDto, UserMaster>(userDto);
            var userId = await _userRepository.AddNewUserAsync(user);
            UserRoles role = new UserRoles
            {
                UserId = userId,
                RoleId = userDto.RoleId,
                IsActive = true
            };
            await _userRepository.AssignRoleToUser(role);
            return userId;
        }

        public async Task UpdateUserAsync(UserMasterDto userDto)
        {
            var user = _mapper.Map<UserMasterDto, UserMaster>(userDto);
            await _userRepository.UpdateUserAsync(user);
        }

        public async Task RemoveUserAsync(int id)
        {
            var user = await _userRepository.GetUserAsync(id);
            user.IsDeleted = true;
            user.IsActive = false;
            user.AccountStatus = (int)AspectEnums.UserAccountStatus.Deleted;
            await _userRepository.UpdateUserAsync(user);
            await _userRepository.RevokeRoleFromUser(user.Id);
        }

        public async Task<int> AssignRoleToUser(UserRolesDto dto)
        {
            var userRole = _mapper.Map<UserRolesDto, UserRoles>(dto);
            return await _userRepository.AssignRoleToUser(userRole);
        }

        public async Task RevokeRoleFromUser(int userId)
        {
            await _userRepository.RevokeRoleFromUser(userId);
        }

        public async Task<IReadOnlyList<RoleMasterDto>> GetUserRolesAsync(int userId)
        {
            var roles = await _userRepository.GetUserRolesAsync(userId);
            return _mapper.Map<IReadOnlyList<RoleMaster>, IReadOnlyList<RoleMasterDto>>(roles);
        }

        public async Task<string> GetUserNameAsync(int userId)
        {
            var user = await _userRepository.GetUserAsync(userId);
            return user.FirstName;
        }

        public async Task<IReadOnlyList<RoleMasterDto>> GetAllRolesAsync()
        {
            var roles = await _userRepository.GetAllRolesAsync();
            return _mapper.Map<IReadOnlyList<RoleMaster>, List<RoleMasterDto>>(roles);
        }

        public async Task<RoleMasterDto> GetRoleByIdAsync(int id)
        {
            var role = await _userRepository.GetRoleByIdAsync(id);
            return _mapper.Map<RoleMaster, RoleMasterDto>(role);
        }

        public async Task<int> AddNewRoleAsync(RoleMasterDto dto)
        {
            var role = _mapper.Map<RoleMasterDto, RoleMaster>(dto);
            return await _userRepository.AddNewRoleAsync(role);
        }

        public async Task UpdateRoleAsync(RoleMasterDto dto)
        {
            var role = _mapper.Map<RoleMasterDto, RoleMaster>(dto);
            await _userRepository.UpdateRoleAsync(role);
        }

    }
}
