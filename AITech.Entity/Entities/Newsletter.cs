using AITech.Entity.Entities.Common;

namespace AITech.Entity.Entities
{
    public class Newsletter:BaseEntity
    {
      

        public string? Email { get; set; }

        public DateTime Date { get; set; }

        public bool Status { get; set; }
    }
}
