using System;
using System.Collections.Generic;

namespace DreamWedds.PersistenceLayer.Entities.Entities
{
    public partial class Rsvpdetails
    {
        public int Rsvpid { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public bool IsComing { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int? GuestCount { get; set; }
        public byte PreferredFood { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string SpecialNote { get; set; }
        public string ImageUrl { get; set; }
        public bool IsDeleted { get; set; }
        public int WeddingId { get; set; }
        public string ParticipatingInEvents { get; set; }
        public string ComingFromCity { get; set; }
        public int? PreferredStayIn { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public int? CreatedBy { get; set; }

        public virtual Wedding Wedding { get; set; }
    }
}
