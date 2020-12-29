using DreamWedds.CommonLayer.Application.Mappings;
using DreamWedds.PersistenceLayer.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DreamWedds.CommonLayer.Application.DTO
{
    public class RoleMasterDTO : IMapFrom<RoleMaster>
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public int? Type { get; set; }
        public int Status { get; set; }
        public bool IsAdmin { get; set; }
        public string RoleDescription { get; set; }
    }
}
