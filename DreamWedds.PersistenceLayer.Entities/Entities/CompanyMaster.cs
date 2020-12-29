using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DreamWedds.PersistenceLayer.Entities.Entities
{
    public class CompanyMaster
    {
        public CompanyMaster()
        {
            //SystemSettings = new HashSet<SystemSettings>();
            //UserMaster = new HashSet<UserMaster>();
        }
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int DivisionId { get; set; }
    }
}
