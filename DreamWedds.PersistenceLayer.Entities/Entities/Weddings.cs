using System;
using System.Collections.Generic;

namespace DreamWedds.PersistenceLayer.Entities.Entities
{
    public class Wedding : IAggregateRoot
    {
        public Wedding()
        {
            //BrideAndMaid = new HashSet<BrideAndMaid>();
            //GroomAndMen = new HashSet<GroomAndMen>();
            //Rsvpdetails = new HashSet<Rsvpdetails>();
            //TimeLine = new HashSet<TimeLine>();
            UserWeddingSubscriptions = new HashSet<UserWeddingSubscriptions>();
            //WeddingEvents = new HashSet<WeddingEvents>();
            //WeddingGallery = new HashSet<WeddingGallery>();
        }

        public int Id { get; set; }
        public DateTime WeddingDate { get; set; }
        public string Title { get; set; }
        public int WeddingStyle { get; set; }
        public string IconUrl { get; set; }
        public int? TemplateId { get; set; }
        public bool IsLoveMarriage { get; set; }
        public int? UserId { get; set; }
        public bool IsDeleted { get; set; }
        public bool? IsActive { get; set; }
        public string BackgroundImage { get; set; }
        public string Quote { get; set; }
        public string FbPageUrl { get; set; }
        public string VideoUrl { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        //public virtual ICollection<BrideAndMaid> BrideAndMaid { get; set; }
        //public virtual ICollection<GroomAndMen> GroomAndMen { get; set; }
        //public virtual ICollection<Rsvpdetails> Rsvpdetails { get; set; }
        //public virtual ICollection<TimeLine> TimeLine { get; set; }
        public virtual ICollection<UserWeddingSubscriptions> UserWeddingSubscriptions { get; set; }
        //public virtual ICollection<WeddingEvents> WeddingEvents { get; set; }
        //public virtual ICollection<WeddingGallery> WeddingGallery { get; set; }
    }
}
