using blazor_universal_prototype.Shared.Models;

namespace blazor_universal_prototype.Shared.Services
{
    public class AttachmentService
    {
        public AttachmentService() { }
        public async Task<List<AttachmentDto>> GetAttachmentsAsync(int emailId)
        {
            await Task.Delay(1000);

            return AllAttachments();
        }

        public async Task<List<AttachmentDto>> GetAttachmentByIdAsync(int id)
        {
            await Task.Delay(1000);
            return AllAttachments().Where(attachment => attachment.MailId == id).ToList();
        }

        private List<AttachmentDto> AllAttachments()
        {
            return new List<AttachmentDto>
            {
                new AttachmentDto { Id = 1, FileName = "Nachricht_20250324_3503.pdf", Comment = "First attachment", MailId = 1, Date = DateTime.Now, Size = 116 },
                new AttachmentDto { Id = 2, FileName = "Nachricht_20250324_3503.pdf", Comment = "First attachment", MailId = 1, Date = DateTime.Now, Size = 116 },
                new AttachmentDto { Id = 3, FileName = "Nachricht_20250324_3503.pdf", Comment = "First attachment", MailId = 3, Date = DateTime.Now, Size = 116 },
                new AttachmentDto { Id = 4, FileName = "Nachricht_20250324_3503.pdf", Comment = "First attachment", MailId = 4, Date = DateTime.Now, Size = 116 },
                new AttachmentDto { Id = 5, FileName = "Nachricht_20250324_3503.pdf", Comment = "First attachment", MailId = 5, Date = DateTime.Now, Size = 116 },
                new AttachmentDto { Id = 6, FileName = "Nachricht_20250324_3503.pdf", Comment = "First attachment", MailId = 6, Date = DateTime.Now, Size = 116 },
                new AttachmentDto { Id = 7, FileName = "Nachricht_20250324_3503.jpg", Comment = "Second attachment", MailId = 7, Date = DateTime.Now, Size = 256 }
            };
        }
    }
}
