namespace blazor_universal_prototype.Shared.Models
{
    public class AttachmentDto
    {
        public int Id { get; set; }
        public string FileName { get; set; } = null!;
        public string Comment { get; set; } = null!;
        public int MailId { get; set; }
        public int Size { get; set; }
        public DateTime Date { get; set; }
    }
}
