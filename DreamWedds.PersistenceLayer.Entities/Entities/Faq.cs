
namespace DreamWedds.PersistenceLayer.Entities.Entities
{
    public class Faq : IAggregateRoot
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public string Website { get; set; }
        public bool IsMainQue { get; set; }
        public int? Sequence { get; set; }
    }
}
