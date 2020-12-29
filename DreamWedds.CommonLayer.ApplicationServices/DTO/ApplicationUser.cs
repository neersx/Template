using System.ComponentModel.DataAnnotations;
using AutoMapper;
using DreamWedds.CommonLayer.Application.Mappings;
using DreamWedds.CommonLayer.Aspects.Security;
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
            profile.CreateMap<UserMaster, ApplicationUser>()
                .ForMember(d => d.Email, opt => opt.MapFrom(s => EncryptionEngine.DecryptString(s.Email)))
                .ForMember(d => d.UserName, opt => opt.MapFrom(s => EncryptionEngine.DecryptString(s.UserName)))
                .ForMember(d => d.Password, opt => opt.MapFrom(s => EncryptionEngine.DecryptString(s.Password)));
            profile.CreateMap<ApplicationUser, UserMaster>()
                .ForMember(d => d.Email, opt => opt.MapFrom(s => EncryptionEngine.EncryptString(s.Email)))
                .ForMember(d => d.UserName, opt => opt.MapFrom(s => EncryptionEngine.EncryptString(s.UserName)))
                .ForMember(d => d.Password, opt => opt.MapFrom(s => EncryptionEngine.EncryptString(s.Password)));
        }
    }

}
