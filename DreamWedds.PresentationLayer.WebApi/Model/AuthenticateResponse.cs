using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DreamWedds.PresentationLayer.WebApi.Model
{
    public class AuthenticateResponse : BaseResponse
    {
        public AuthenticateResponse(Guid correlationId) : base(correlationId)
        {
        }

        public AuthenticateResponse()
        {
        }

        public bool IsSuccess { get; set; }
        public int ExpiresIn { get; set; }
        public string Token { get; set; }
    }
}
