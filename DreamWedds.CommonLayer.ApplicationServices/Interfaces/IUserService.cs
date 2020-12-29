using DreamWedds.CommonLayer.Application.DTO;
using DreamWedds.CommonLayer.Aspects.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DreamWedds.CommonLayer.Application.Interfaces
{
    public interface IUserService
    {
        Task<string> GetUserNameAsync(int userId);
        Task<ApplicationUser> GetUserAsync(int userId);
        Task<ApplicationUser> AuthenticateUser(string userName, string Password);
        Task<List<ApplicationUser>> GetAllUsers();
    }
}
