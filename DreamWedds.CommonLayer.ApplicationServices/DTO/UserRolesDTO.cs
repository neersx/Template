using AutoMapper;
using DreamWedds.CommonLayer.Application.Mappings;
using DreamWedds.PersistenceLayer.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DreamWedds.CommonLayer.Application.DTO
{
    public class UserRolesDTO : IMapFrom<UserRoles>, IMapFrom<RoleMaster>
    {
        public int RoleId { get; set; }
        public int? UserId { get; set; }
        public bool IsActive { get; set; }
        public string RoleName { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<RoleMaster, UserRolesDTO>()
                .ForMember(d => d.RoleName, opt => opt.MapFrom(s => s.Name));
            profile.CreateMap<UserRolesDTO, UserRoles>();
            profile.CreateMap<UserRoles, UserRolesDTO>();
        }
        public virtual RoleMasterDTO Role { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}
