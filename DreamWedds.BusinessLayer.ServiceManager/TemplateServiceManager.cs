using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DreamWedds.CommonLayer.Application.DTO;
using DreamWedds.CommonLayer.Application.Interfaces;
using DreamWedds.PersistenceLayer.Entities.Entities;
using DreamWedds.PersistenceLayer.Repository.PersistenceServices;

namespace DreamWedds.BusinessLayer.ServiceManager
{
    public class TemplateServiceManager : ITemplateService
    {
        private readonly ITemplateRepository _templateRepository;
        private readonly IMapper _mapper;

        public TemplateServiceManager(ITemplateRepository templatePersistenceService, IMapper mapper)
        {
            _mapper = mapper;
            _templateRepository = templatePersistenceService;
        }
        public async Task<List<TemplateMasterDTO>> GetAllTemplates()
        {
            var data = await _templateRepository.GetAllTemplates();
            return _mapper.Map<List<TemplateMaster>, List<TemplateMasterDTO>>(data);
        }

        public async Task<List<TemplateMasterDTO>> GetWeddingTemplates()
        {
            var data = await _templateRepository.GetWeddingTemplates();
            return _mapper.Map<List<TemplateMaster>, List<TemplateMasterDTO>>(data);
        }

        public async Task<List<TemplateMasterDTO>> GetEmailTemplates()
        {
            var data = await _templateRepository.GetEmailTemplates();
            return _mapper.Map<List<TemplateMaster>, List<TemplateMasterDTO>>(data);
        }

        public async Task<TemplateMasterDTO> GetTemplateById(int id)
        {
            var data = await _templateRepository.GetTemplateById(id);
            return _mapper.Map<TemplateMaster, TemplateMasterDTO>(data);
        }

        public async Task<List<TemplateImagesDTO>> SubmitTemplateImages(List<TemplateImagesDTO> images)
        {
            var img = _mapper.Map<List<TemplateImagesDTO>, List<TemplateImages>>(images);
            var result = await _templateRepository.SubmitTemplateImages(img);
            return _mapper.Map<List<TemplateImages>, List<TemplateImagesDTO>>(result);
        }

        public async Task<List<CommonSetupDTO>> GetTemplateCommonSetup()
        {
            var settings = await _templateRepository.GetTemplateCommonSetup();
            return _mapper.Map<List<CommonSetup>, List<CommonSetupDTO>>(settings);
        }
    }
}
