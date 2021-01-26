using System;
using System.Collections.Generic;
using System.Text;

namespace AdminProject.CommonLayer.Aspects.Models
{
    public class CodeDescription
    {
        public string Code { get; set; }

        public string Description { get; set; }
        
        public override int GetHashCode()
        {
            return new {Code, Description}.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            var other = (CodeDescription) obj;

            return Code == other.Code &&
                   Description == other.Description;
        }
    }
}
