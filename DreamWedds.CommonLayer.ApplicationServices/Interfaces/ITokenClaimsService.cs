using System.Threading.Tasks;

namespace DreamWedds.CommonLayer.Application.Interfaces
{
    public interface ITokenClaimsService
    {
        Task<string> GetTokenAsync(int id);
        Task<string> GetToken(int id);
    }
}
