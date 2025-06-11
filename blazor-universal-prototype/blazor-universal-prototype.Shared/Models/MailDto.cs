namespace blazor_universal_prototype.Shared.Models
{
    public class MailDto
    {
        public int Id { get; set; }
        public string Subject { get; set; } = null!;
        public string Branch { get; set; } = null!;
        public DateTime Date { get; set; }
        public string SentBy { get; set; } = null!;
        public string Area { get; set; } = null!;
        public string Message { get; set; } = null!;
        public bool IsRead { get; set; }

    }
}
