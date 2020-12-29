using System.Threading.Tasks;
using AutoMapper;
using DreamWedds.CommonLayer.Application.DTO;
using DreamWedds.CommonLayer.Application.Interfaces;
using DreamWedds.PersistenceLayer.Entities.Entities;
using DreamWedds.PersistenceLayer.Repository.PersistenceServices;

namespace DreamWedds.BusinessLayer.ServiceManager
{
    public class EmailServiceManager : IEmailService
    {
        private readonly IEmailRepository _emailRepository;
        private readonly IMapper _mapper;

        public EmailServiceManager(IEmailRepository emailRepository, IMapper mapper)
        {
            _mapper = mapper;
            _emailRepository = emailRepository;
        }
        public Task<int> SubmitContactUs(ContactUsDTO model)
        {
            return _emailRepository.SubmitContactUs(_mapper.Map<ContactUsDTO, ContactUs>(model));
        }
    }
}
