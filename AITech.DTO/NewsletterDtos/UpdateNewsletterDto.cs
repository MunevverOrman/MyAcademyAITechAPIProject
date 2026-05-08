namespace AITech.DTO.NewsletterDtos
{
    public class UpdateNewsletterDto
    {

        public int Id { get; set; }

        public string? Email { get; set; }

        public DateTime Date { get; set; }

        public bool Status { get; set; }
    }
}
