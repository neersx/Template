﻿using AutoMapper;
using DreamWedds.CommonLayer.Application.Mappings;
using DreamWedds.CommonLayer.Aspects.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DreamWedds.PresentationLayer.WebApi.Model
{
    public class LoginRequest : BaseRequest, IMapFrom<LoginRequest>
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<LoginRequest, LoginRequest>()
                .ForMember(d => d.Username, opt => opt.MapFrom(s => EncryptionEngine.EncryptString(s.Username)))
                .ForMember(d => d.Password, opt => opt.MapFrom(s => EncryptionEngine.EncryptString(s.Password)));
        }
    }
}