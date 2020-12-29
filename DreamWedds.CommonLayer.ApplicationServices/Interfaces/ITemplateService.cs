using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DreamWedds.CommonLayer.Application.DTO;
using DreamWedds.PersistenceLayer.Entities.Entities;

namespace DreamWedds.CommonLayer.Application.Interfaces
{
    public interface ITemplateService
    {
        Task<List<TemplateMasterDTO>> GetAllTemplates();
        Task<List<TemplateMasterDTO>> GetWeddingTemplates();
        Task<List<TemplateMasterDTO>> GetEmailTemplates();
        Task<TemplateMasterDTO> GetTemplateById(int id);
        Task<List<TemplateImagesDTO>> SubmitTemplateImages(List<TemplateImagesDTO> images);
        Task<List<CommonSetupDTO>> GetTemplateCommonSetup();
    }
}
