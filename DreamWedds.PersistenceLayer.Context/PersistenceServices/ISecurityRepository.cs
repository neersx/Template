using System.Threading.Tasks;
using DreamWedds.PersistenceLayer.Entities.Entities;

namespace DreamWedds.PersistenceLayer.Repository.PersistenceServices
{
    public interface ISecurityRepository
    {
        Task<bool> SaveOtpAsync(OtpMaster otp);
        Task<bool> ValidateGuidAsync(string guid);
    }
}
