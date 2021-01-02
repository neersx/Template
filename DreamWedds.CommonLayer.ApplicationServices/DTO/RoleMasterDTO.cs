﻿using DreamWedds.CommonLayer.Application.Mappings;
using DreamWedds.PersistenceLayer.Entities.Entities;
using AutoMapper;

namespace DreamWedds.CommonLayer.Application.DTO
{
    public class RoleMasterDto : IMapFrom<RoleMaster>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int? Type { get; set; }
        public int Status { get; set; }
        public bool IsAdmin { get; set; }
        public string RoleDescription { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<RoleMaster, RoleMasterDto>();
            profile.CreateMap<RoleMasterDto, RoleMaster>();
        }
    }
}
