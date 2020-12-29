using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DreamWedds.PersistenceLayer.Entities.Entities;
using DreamWedds.PersistenceLayer.Repository.PersistenceServices;
using DreamWedds.PersistenceLayer.Repository.Repository;

namespace DreamWedds.PersistenceLayer.Repository.Impl
{
    public class EmailDataImpl : IEmailRepository
    {
        private readonly IAsyncRepository<ContactUs> _contactRepository;
        protected readonly DreamWeddsDBContext DbContext;

        public EmailDataImpl(IAsyncRepository<ContactUs> contactRepository, DreamWeddsDBContext context)
        {
            DbContext = context;
            _contactRepository = contactRepository;
        }
        public async Task<int> SubmitContactUs(ContactUs model)
        {
            var contactUs = await _contactRepository.AddAsync(model);
            return contactUs.Id;
        }
    }
}
