﻿using System.Threading.Tasks;
using AdminProject.CommonLayer.Aspects.Utitlities;
using AdminProject.PersistenceLayer.Entities.Entities;
using AdminProject.PersistenceLayer.Entities.Specifications;
using AdminProject.PersistenceLayer.Repository.PersistenceServices;
using AdminProject.PersistenceLayer.Repository.Repository;
using Microsoft.EntityFrameworkCore;

namespace AdminProject.PersistenceLayer.Repository.Impl
{
    public class EmailDataImpl : IEmailRepository
    {
        private readonly IAsyncRepository<ContactUs> _contactRepository;
        private readonly IAsyncRepository<EmailTemplate> _emailTemplateRepository;
        private readonly AdminDbContext _dbContext;

        public EmailDataImpl(IAsyncRepository<ContactUs> contactRepository, AdminDbContext context, IAsyncRepository<EmailTemplate> emailTemplateRepository)
        {
            _dbContext = context;
            _emailTemplateRepository = emailTemplateRepository;
            _contactRepository = contactRepository;
        }

        public async Task<int> SubmitContactUs(ContactUs model)
        {
            var contactUs = await _contactRepository.AddAsync(model);
            return contactUs.Id;
        }

        public async Task<EmailTemplate> GetEmailWithFieldsAsync(AspectEnums.TemplateType type,
            AspectEnums.EmailTemplateCode? code)
        {
            if (code != null) return await _dbContext.EmailTemplate.Include("EmailMergeFields").FirstOrDefaultAsync(x => x.Type == (int)type && x.TemplateCode == (int)code);
            return await _dbContext.EmailTemplate.Include("EmailMergeFields").AsNoTracking().FirstOrDefaultAsync(x => x.Type == (int)type);
        }

        public async Task<EmailTemplate> GetTemplateAsync(AspectEnums.TemplateType type,
            AspectEnums.EmailTemplateCode? code)
        {
            var spec = code != null
                ? new EmailTemplateFilterSpecification((int)type, (int)code)
                : new EmailTemplateFilterSpecification((int)type);

            return await _emailTemplateRepository.FirstOrDefaultAsync(spec);
        }
    }
}