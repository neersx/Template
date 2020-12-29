using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DreamWedds.PersistenceLayer.Entities.Entities;

namespace DreamWedds.PersistenceLayer.Repository.PersistenceServices
{
    public interface ITemplateRepository
    {
        Task<List<TemplateMaster>> GetAllTemplates();
        Task<List<TemplateMaster>> GetWeddingTemplates();
        Task<List<TemplateMaster>> GetEmailTemplates();
        Task<TemplateMaster> GetTemplateById(int id);
        Task<List<CommonSetup>> GetTemplateCommonSetup();
        Task<List<TemplateImages>> SubmitTemplateImages(List<TemplateImages> Images);
    }
}
