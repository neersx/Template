using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DreamWedds.CommonLayer.Application.DTO;
using DreamWedds.CommonLayer.Application.Interfaces;
using DreamWedds.PersistenceLayer.Entities.Entities;
using DreamWedds.PersistenceLayer.Repository.PersistenceServices;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using MimeKit;

namespace DreamWedds.BusinessLayer.ServiceManager
{
    public class EmailServiceManager : IEmailService
    {
        private readonly IEmailRepository _emailRepository;
        private readonly IMapper _mapper;
        private readonly SmtpSettings _smtpSettings;
        private readonly IWebHostEnvironment _env;

        public EmailServiceManager(IEmailRepository emailRepository, IMapper mapper, IOptions<SmtpSettings> smtpSettings, IWebHostEnvironment env)
        {
            _mapper = mapper;
            _emailRepository = emailRepository;
            _smtpSettings = smtpSettings.Value;
            _env = env;
        }
        public Task<int> SubmitContactUs(ContactUsDTO model)
        {
            return _emailRepository.SubmitContactUs(_mapper.Map<ContactUsDTO, ContactUs>(model));
        }

        public async Task PrepareAndSendEmailAsync(UserMasterDto user, string otherText)
        {
            var email = PrepareEmailBody(user, otherText);
            await SendEmailAsync(email);
        }

        private EmailsDto PrepareEmailBody(UserMasterDto user, string otherText)
        {
            return new EmailsDto
            {
                FromEmail = _smtpSettings.SenderEmail,
                FromName = _smtpSettings.SenderName,
                ToEmail = user.Email,
                ToName = user.FirstName,
                Mobile = user.Mobile,
                Message = "Test email for forget password.",
                Body = "Tes body of email" + " " + otherText,
                AttachmentFileName = "Attachment",
                Subject = "Test email"
            };
        }

        public async Task SendEmailAsync(EmailsDto mailRequest)
        {
            var email = new MimeMessage
            {
                Sender = MailboxAddress.Parse(_smtpSettings.SenderEmail)
            };
            email.To.Add(MailboxAddress.Parse(mailRequest.ToEmail));
            email.Subject = mailRequest.Subject;
            var builder = new BodyBuilder();
            if (mailRequest.Attachments != null)
            {
                foreach (var file in mailRequest.Attachments.Where(file => file.Length > 0))
                {
                    byte[] fileBytes;
                    await using (var ms = new MemoryStream())
                    {
                        await file.CopyToAsync(ms);
                        fileBytes = ms.ToArray();
                    }
                    builder.Attachments.Add(file.FileName, fileBytes, ContentType.Parse(file.ContentType));
                }
            }
            builder.HtmlBody = mailRequest.Body;
            email.Body = builder.ToMessageBody();

            using var client = new SmtpClient
            {
                ServerCertificateValidationCallback = (s, c, h, e) => true
            };

            if (_env.IsDevelopment())
            {
                await client.ConnectAsync(_smtpSettings.Server, _smtpSettings.Port, true);
            }
            else
            {
                await client.ConnectAsync(_smtpSettings.Server);
            }

            await client.AuthenticateAsync(_smtpSettings.Username, _smtpSettings.Password);
            await client.SendAsync(email);
            await client.DisconnectAsync(true);
        }
    }
}
