
using DreamWedds.PersistenceLayer.Entities.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DreamWedds.PersistenceLayer.Repository.PersistenceServices
{
    public interface IUserRepository
    {
        Task<UserMaster> GetUserAsync(int id);
        Task<IReadOnlyList<UserMaster>> GetAllUsers();
        Task<UserMaster> AuthenticateUser(string userName, string password);
    }
}
