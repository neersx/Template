using DreamWedds.PersistenceLayer.Entities.Entities;
using DreamWedds.PersistenceLayer.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DreamWedds.PersistenceLayer.Infrastructure;
using DreamWedds.PersistenceLayer.Repository.PersistenceServices;
using DreamWedds.PersistenceLayer.Repository.Repository;

namespace DreamWedds.PersistenceLayer.Repository.Impl
{
    public class UserDataImpl : IUserRepository
    {
        private readonly IAsyncRepository<UserMaster> _userRepository;
        protected readonly AdminDbContext DbContext;

        public UserDataImpl(IAsyncRepository<UserMaster> userRepository, AdminDbContext context)
        {
            _userRepository = userRepository;
            DbContext = context;
        }

        public async Task<IReadOnlyList<UserMaster>> GetAllUsers()
        {
            return await _userRepository.ListAllAsync();
        }

        public UserMaster GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<UserMaster> AuthenticateUser(string userName, string password)
        {
            //var specification = new UserFilterSpecification(userName, password);
            //return await _userRepository.AnyAsync(specification);

            var user = await DbContext.UserMasters.FirstOrDefaultAsync(x => x.Email == userName && x.Password == password) ??
                       await DbContext.UserMasters.FirstOrDefaultAsync(x => x.UserName == userName && x.Password == password);
            return user;
        }

        public async Task<UserMaster> GetUserAsync(int id)
        {
            return await _userRepository.GetByIdAsync(id);
        }

        public async Task<string> GetUserNameAsync(int userId)
        {
            return await _userRepository.GetNameByIdAsync(userId);
        }


        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(UserMaster obj)
        {
            throw new NotImplementedException();
        }
    }
}
