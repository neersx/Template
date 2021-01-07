using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace AdminProject.PresentationLayer.WebApi.Helpers
{

    public class CustomAppException : Exception
    {
        public CustomAppException() : base() {}

        public CustomAppException(string message) : base(message) { }

        public CustomAppException(string message, params object[] args) 
            : base(String.Format(CultureInfo.CurrentCulture, message, args))
        {
        }
    }
}
