using System.ComponentModel.DataAnnotations;
using AutoMapper;
using DreamWedds.CommonLayer.Application.Mappings;
using DreamWedds.PersistenceLayer.Entities.Common;
using DreamWedds.PersistenceLayer.Entities.Entities;
using Microsoft.AspNetCore.Identity;

namespace DreamWedds.CommonLayer.Application.DTO
{
    public class ApplicationUser : IMapFrom<UserMaster>
    {
        public int Id { get; protected set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Image { get; set; }
        public string EmpCode { get; set; }
        public string Email { get; set; }
        public int? AccountStatus { get; set; }
        public bool? IsActive { get; set; }
        public int? SeniorEmpId { get; set; }
        public bool? IsEmployee { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public int CompanyId { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<UserMaster, ApplicationUser>();
            profile.CreateMap<ApplicationUser, UserMaster>();
        }
    }

}
