using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DreamWedds.CommonLayer.Application.DTO
{

    public class WeddingDTO
    {

        public int Id { get; set; }

        [DisplayFormat(DataFormatString = "{dd MM yyyy}")]
        
        public string WeddingDate { get; set; }
        
        public string Title { get; set; }
        
        public string WeddingStyle { get; set; }

        
        public string IconUrl { get; set; }
        
        public int TemplateID { get; set; }
        

        public bool IsDeleted { get; set; }
        
        public bool IsActive { get; set; }
        
        public string BackgroundImage { get; set; }
        
        public string Quote { get; set; }
        
        public string FbPageUrl { get; set; }
        
        public string VideoUrl { get; set; }
        
        public string TemplateName { get; set; }
        
        public string TemplateImageUrl { get; set; }
        
        public string TemplatePreviewUrl { get; set; }
        
        public string SubscriptionEndDate { get; set; }

        public bool IsLoveMarriage { get; set; }
        public UserWeddingSubscriptionDTO UserWeddingSubscription { get; set; }
    }


    public class BrideAndMaidDTO
    {
        
        public int BrideAndMaidID { get; set; }
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        [DisplayFormat(DataFormatString = "{0:mm dd yyyy}", ApplyFormatInEditMode = true)]
        public string DateofBirth { get; set; }
        
        public int WeddingID { get; set; }

        
        public bool IsBride { get; set; }

        
        public int RelationWithBride { get; set; }
        
        public string strRelationWithBride { get; set; }
        
        public string Imageurl { get; set; }
        //
        //public int CreatedBy { get; set; }
        
        public bool IsDeleted { get; set; }
        
        public bool IsActive { get; set; }
        //
        //public Nullable<int> ModifiedBy { get; set; }
        
        public string AboutBrideMaid { get; set; }
        
        public string FbUrl { get; set; }
        
        public string GoogleUrl { get; set; }
        
        public string InstagramUrl { get; set; }
        
        public string LinkedinUrl { get; set; }
    }

    public class GroomAndMenDTO
    {
        
        public int GroomAndMenID { get; set; }
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public string DateofBirth { get; set; }
        
        public int WeddingID { get; set; }

        
        public bool IsGroom { get; set; }
        //
        //public Nullable<int> RelationWithGroom { get; set; }
        
        public int RelationWithGroom { get; set; }
        
        public string strRelationWithGroom { get; set; }
        
        public string Imageurl { get; set; }
        //
        //public int CreatedBy { get; set; }
        //
        //public bool IsDeleted { get; set; }
        //
        //public bool IsActive { get; set; }
        //
        //public Nullable<int> ModifiedBy { get; set; }
        
        public string AboutMen { get; set; }
        
        public string FbUrl { get; set; }
        
        public string GoogleUrl { get; set; }
        
        public string InstagramUrl { get; set; }
        
        public string LinkedinUrl { get; set; }
    }
    [DataContract]
    public class WeddingEventDTO
    {
        
        public int WeddingEventID { get; set; }
        
        public string EventDate { get; set; }
        
        public string Title { get; set; }
        
        public int WeddingID { get; set; }
        
        public string ImageUrl { get; set; }
        
        public string Name { get; set; }
        
        public bool IsDeleted { get; set; }
        
        public bool IsActive { get; set; }
        
        public string StartTime { get; set; }
        
        public string EndTime { get; set; }
        
        public  List<VenueDTO> Venues { get; set; }
    }
    [DataContract]
    public class VenueDTO
    {
        
        public int VenueID { get; set; }
        
        public string Name { get; set; }
        
        public string VenueImageUrl { get; set; }
        
        public string VenueWebsite { get; set; }
        
        public string OwnerName { get; set; }
        
        public bool IsDeleted { get; set; }
        
        public bool IsActive { get; set; }
        
        public string VenuePhone { get; set; }
        
        public string VenueMobile { get; set; }
        
        public int WeddingEventID { get; set; }
        
    }

    public class TimeLineDTO
    {
        
        public int TimeLineID { get; set; }
        
        public string StoryDate { get; set; }
        
        public string Title { get; set; }
        
        public string Story { get; set; }
        
        public string ImageUrl { get; set; }
        
        public int WeddingID { get; set; }
        
        public string Location { get; set; }
        
        public bool IsDeleted { get; set; }

    }

    [DataContract]
    public class WeddingGalleryDTO
    {
        
        public int WeddingGalleryID { get; set; }
        
        public string ImageTitle { get; set; }
        
        public string ImageName { get; set; }
        
        public string DateTaken { get; set; }
        
        public string Place { get; set; }
        
        public int WeddingID { get; set; }
        
        public string ImageUrl { get; set; }
        
        public int CreatedBy { get; set; }
        
        public System.DateTime CreatedDate { get; set; }

    }
    [DataContract]
    public class RSVPDetailDTO
    {
        public int RSVPID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public bool IsComing { get; set; }
        public Nullable<System.DateTime> FromDate { get; set; }
        public Nullable<System.DateTime> ToDate { get; set; }
        public Nullable<int> GuestCount { get; set; }
        public byte PreferredFood { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string SpecialNote { get; set; }
        public string ImageUrl { get; set; }
        public bool IsDeleted { get; set; }
        public int WeddingID { get; set; }
        public string ParticipatingInEvents { get; set; }
        public string ComingFromCity { get; set; }
        public Nullable<int> PreferredStayIn { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<int> CreatedBy { get; set; }

    }


    [DataContract]
    public class EventAndVenueDTO
    {
        
        public int WeddingEventID { get; set; }
        
        public string EventDate { get; set; }
        
        public string Title { get; set; }
        
        public int WeddingID { get; set; }
        
        public string ImageUrl { get; set; }
        
        public bool IsDeleted { get; set; }
        
        public bool IsActive { get; set; }
        
        public string StartTime { get; set; }
        
        public string EndTime { get; set; }

        
        public int VenueID { get; set; }
        
        public string Name { get; set; }
        
        public int AddressID { get; set; }
        
        public string VenueImageUrl { get; set; }
        
        public string VenueWebsite { get; set; }
        
        public string OwnerName { get; set; }
        
        public string VenuePhone { get; set; }
        
        public string VenueMobile { get; set; }

        
        public string Address1 { get; set; }
        
        public string Address2 { get; set; }
        
        public string City { get; set; }
        
        public string State { get; set; }
        
        public int Country { get; set; }
        
        public int PinCode { get; set; }
        
        public int AddressType { get; set; }
        
        public int AddressStatus { get; set; }
        
        public string Lattitude { get; set; }
        
        public string Longitude { get; set; }


    }
}
