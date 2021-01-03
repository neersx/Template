using System;
using System.Collections.Generic;
using System.Text;

namespace DreamWedds.CommonLayer.Application.DTO
{
    public class SmtpSettings
    {
        public string Server { get; set; }
        public int Port { get; set; }
        public string SenderName { get; set; }
        public string SenderEmail { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsSsl { get; set; }
    }
}
