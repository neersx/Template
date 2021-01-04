﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AutoMapper;
using DreamWedds.CommonLayer.Application.Mappings;
using DreamWedds.CommonLayer.Aspects.Security;
using DreamWedds.PersistenceLayer.Entities.Common;
using DreamWedds.PersistenceLayer.Entities.Entities;

namespace DreamWedds.CommonLayer.Application.DTO
{

    public class LoginModel : IMapFrom<LoginModel>
    {
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Guid { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<LoginModel, LoginModel>()
                .ForMember(d => d.Email, opt => opt.MapFrom(s => EncryptionEngine.DecryptString(s.Email)))
                .ForMember(d => d.UserName, opt => opt.MapFrom(s => EncryptionEngine.DecryptString(s.UserName)))
                .ForMember(d => d.Password, opt => opt.MapFrom(s => EncryptionEngine.DecryptString(s.Password)));
            profile.CreateMap<LoginModel, LoginModel>()
                .ForMember(d => d.Email, opt => opt.MapFrom(s => EncryptionEngine.EncryptString(s.Email)))
                .ForMember(d => d.UserName, opt => opt.MapFrom(s => EncryptionEngine.EncryptString(s.UserName)))
                .ForMember(d => d.Password, opt => opt.MapFrom(s => EncryptionEngine.EncryptString(s.Password)));
        }
    }
    public class UserMasterDto : BaseEntity, IMapFrom<UserMaster>
    {
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
        public int RoleId { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<UserMaster, UserMasterDto>()
                .ForMember(d => d.Email, opt => opt.MapFrom(s => EncryptionEngine.DecryptString(s.Email)))
                .ForMember(d => d.UserName, opt => opt.MapFrom(s => EncryptionEngine.DecryptString(s.UserName)))
                .ForMember(d => d.Password, opt => opt.MapFrom(s => EncryptionEngine.DecryptString(s.Password)));
            profile.CreateMap<UserMasterDto, UserMaster>()
                .ForMember(d => d.Email, opt => opt.MapFrom(s => EncryptionEngine.EncryptString(s.Email)))
                .ForMember(d => d.UserName, opt => opt.MapFrom(s => EncryptionEngine.EncryptString(s.UserName)))
                .ForMember(d => d.Password, opt => opt.MapFrom(s => EncryptionEngine.EncryptString(s.Password)));
        }
    }

}
