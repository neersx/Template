﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DreamWedds.PresentationLayer.WebApi.Model
{
    /// <summary>
    /// Base class used by API responses
    /// </summary>
    public abstract class BaseResponse : BaseMessage
    {
        public BaseResponse(Guid correlationId) : base()
        {
            base._correlationId = correlationId;
        }

        public BaseResponse()
        {
        }
    }
}
