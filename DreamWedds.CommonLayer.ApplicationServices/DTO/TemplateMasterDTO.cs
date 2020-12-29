using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DreamWedds.CommonLayer.Application.Mappings;
using DreamWedds.PersistenceLayer.Entities.Entities;

namespace DreamWedds.CommonLayer.Application.DTO
{
    public class TemplateMasterDTO : IMapFrom<TemplateMaster>
    {
        public int Id { get; set; }
        public string TemplateName { get; set; }
        public string TemplateTags { get; set; }
        public string TemplateUrl { get; set; }
        public string TemplateFolderPath { get; set; }
        public string ThumbnailImageUrl { get; set; }
        public string TemplateScreenshotUrl { get; set; }
        public string TemplatePreviewUrl { get; set; }
        public string TagLine { get; set; }
        public int? Cost { get; set; }
        public string AboutTemplate { get; set; }
        public string UrlIdentifier { get; set; }
        public virtual List<TemplateImagesDTO> TemplateImages { get; set; }
        // 
        // public List<WeddingDTO> Weddings { get; set; }
        //
        public string TemplateTypeText { get; set; }
        public int TemplateType { get; set; }
        public string TemplateTagName { get; set; }
        public string Features { get; set; }
        public bool IsDeleted { get; set; }
        public string TemplateFeatureText { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public void Mapping(Profile profile)
        {
            profile.CreateMap<TemplateMaster, TemplateMasterDTO>();
            profile.CreateMap<TemplateMasterDTO, TemplateMaster>();
        }
    }

    [Serializable]
    public class TemplateImagesDTO : IMapFrom<TemplateImages>
    {
        public int Id { get; set; }
        public string ImageName { get; set; }
        public string ImageTitle { get; set; }
        public string ImageTagLine { get; set; }
        public string ImageUrl { get; set; }
        public string ImageFolderPath { get; set; }
        public bool IsBannerImage { get; set; }
        public int TemplateId { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
        public int? ImageType { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<TemplateImages, TemplateImagesDTO>();
            profile.CreateMap<TemplateImagesDTO, TemplateImages>();
        }
    }

    [Serializable]
    public class TemplatePageDTO
    {
        public int PageID { get; set; }
        public string PageName { get; set; }
        public string Title { get; set; }
        public string PageContent { get; set; }
        public string PageUrl { get; set; }
        public string PageFolderPath { get; set; }
        public string ThumbnailImageUrl { get; set; }
        public int TemplateID { get; set; }
        public int CreatedBy { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }

    }

    public class TemplateMergeFieldBO
    {
        public int PK_ID { get; set; }
        public string MERGEFIELD_NAME { get; set; }
        public string SRC_FIELD { get; set; }
        public string SRC_FIELD_VALUE { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> TemplateID { get; set; }
        public int CreatedBy { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }

        // public virtual TemplateMasterBO TemplateMaster { get; set; }
    }

}
