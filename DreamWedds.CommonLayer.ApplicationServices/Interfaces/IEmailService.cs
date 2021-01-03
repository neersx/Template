using System.Threading.Tasks;
using DreamWedds.CommonLayer.Application.DTO;

namespace DreamWedds.CommonLayer.Application.Interfaces
{
    public interface IEmailService
    {
        Task<int> SubmitContactUs(ContactUsDTO model);
        Task SendEmailAsync(EmailsDto mailRequest);
        Task PrepareAndSendEmailAsync(UserMasterDto user, string otherText);
    }
}
