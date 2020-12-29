﻿using AutoMapper;
using DreamWedds.CommonLayer.Application.DTO;
using DreamWedds.CommonLayer.Application.Interfaces;
using DreamWedds.PersistenceLayer.Entities.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using DreamWedds.CommonLayer.Aspects.Security;
using DreamWedds.PersistenceLayer.Repository.PersistenceServices;
using Microsoft.AspNetCore.Http;

namespace DreamWedds.BusinessLayer.ServiceManager
{
    public class UserServiceManager : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserServiceManager( IUserRepository userPersistenceService, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _mapper = mapper;
            _userRepository = userPersistenceService;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<ApplicationUser> GetUserAsync(int id)
        {
            var user = await _userRepository.GetUserAsync(id);
            //var userId = _httpContextAccessor.HttpContext.User.GetLoggedInUserId<string>();
            return _mapper.Map<UserMaster, ApplicationUser>(user);
        }

        public async Task<ApplicationUser> AuthenticateUser(string userName, string password)
        {
            userName = EncryptionEngine.EncryptString(userName);
            password = EncryptionEngine.EncryptString(password);
            var user = await _userRepository.AuthenticateUser(userName, password);
            return _mapper.Map<UserMaster, ApplicationUser>(user);
        }
        public async Task<List<ApplicationUser>> GetAllUsers()
        {
            var user = await _userRepository.GetAllUsers();

            var userDto = _mapper.Map<IReadOnlyList<UserMaster>, List<ApplicationUser>>(user);

            return userDto;
        }
        public async Task<string> GetUserNameAsync(int userId)
        {
            var user = await _userRepository.GetUserAsync(userId);

            return user.FirstName;
        }
    }
}