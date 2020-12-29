using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DreamWedds.CommonLayer.Application.DTO;

namespace DreamWedds.CommonLayer.Application.Interfaces
{
    public interface IEmailService
    {
        Task<int> SubmitContactUs(ContactUsDTO model);
    }
}
