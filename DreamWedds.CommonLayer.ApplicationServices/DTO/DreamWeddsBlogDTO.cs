using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using DreamWedds.CommonLayer.Application.Mappings;
using DreamWedds.PersistenceLayer.Entities.Entities;

namespace DreamWedds.CommonLayer.Application.DTO
{
    public class DreamWeddsBlogDTO : IMapFrom<DreamWeddsBlog>, IMapFrom<SideBarList>
    {
        public int Id { get; set; }
        public string BlogName { get; set; }
        public string Title { get; set; }
        public string BlogSubject { get; set; }
        public string Quote { get; set; }
        public string AuthorName { get; set; }
        [AllowHtml]
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public string SpecialNote { get; set; }
        public int Likes { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<DreamWeddsBlog, DreamWeddsBlogDTO>();
            profile.CreateMap<DreamWeddsBlogDTO, DreamWeddsBlog>();

            profile.CreateMap<DreamWeddsBlogDTO, SideBarList>()
                .ForMember(x => x.Title, opt => opt.MapFrom(y => y.Title))
                .ForMember(x => x.ImageUrl, opt => opt.MapFrom(y => y.ImageUrl))
                .ForMember(x => x.Name, opt => opt.MapFrom(y => y.BlogName))
                .ForMember(x => x.Date, opt => opt.MapFrom(y => y.CreatedDate));
        }

    }
}
