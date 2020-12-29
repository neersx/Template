using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DreamWedds.PersistenceLayer.Entities.Entities;

namespace DreamWedds.PersistenceLayer.Repository.PersistenceServices
{
    public interface IEmailRepository
    {
        Task<int> SubmitContactUs(ContactUs model);
    }
}
