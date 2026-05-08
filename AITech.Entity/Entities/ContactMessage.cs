using AITech.Entity.Entities.Common;

namespace AITech.Entity.Entities
{
    public class ContactMessage:BaseEntity
    {

        public string? Name { get; set; }

        public string? Email { get; set; }

        public string? Subject { get; set; }

        public string? Message { get; set; }

        public DateTime SendDate { get; set; } 

        public bool IsRead { get; set; }      
    }
}
