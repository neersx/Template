using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DreamWedds.CommonLayer.Aspects.Utitlities;
using DreamWedds.PersistenceLayer.Entities.Entities;
using DreamWedds.PersistenceLayer.Repository.PersistenceServices;
using DreamWedds.PersistenceLayer.Repository.Repository;
using Microsoft.EntityFrameworkCore;

namespace DreamWedds.PersistenceLayer.Repository.Impl
{
    public class TemplateDataImpl : ITemplateRepository
    {
        private readonly IAsyncRepository<TemplateMaster> _templateRepository;
        protected readonly DreamWeddsDBContext DbContext;

        public TemplateDataImpl(IAsyncRepository<TemplateMaster> templateRepository, DreamWeddsDBContext context)
        {
            DbContext = context;
            _templateRepository = templateRepository;
        }

        public async Task<List<TemplateMaster>> GetAllTemplates()
        {
            var data = await _templateRepository.ListAllAsync();
            return data as List<TemplateMaster>;
        }

        public async Task<List<TemplateMaster>> GetWeddingTemplates()
        {
            var data = await DbContext.TemplateMasters.Where(x => x.TemplateType == (int)AspectEnums.TemplateType.Wedding).ToListAsync();
            return data;
        }

        public async Task<List<TemplateMaster>> GetEmailTemplates()
        {
            var data = await DbContext.TemplateMasters.Where(x => x.TemplateType == (int)AspectEnums.TemplateType.Email).ToListAsync();
            return data;
        }

        public async Task<TemplateMaster> GetTemplateById(int id)
        {
            return await _templateRepository.GetByIdAsync(id);
        }

        public async Task<List<CommonSetup>> GetTemplateCommonSetup()
        {
            return await DbContext.CommonSetup.Where(x =>
                x.ParentId == (int)AspectEnums.CommonTableMainType.Template).ToListAsync();
        }

        public async Task<List<TemplateImages>> SubmitTemplateImages(List<TemplateImages> images)
        {
            foreach (var image in images)
            {
                await DbContext.TemplateImages.AddAsync(image);
            }
            await DbContext.SaveChangesAsync();
            return images;
        }
    }
}
