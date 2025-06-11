using blazor_universal_prototype.Shared.Models;

namespace blazor_universal_prototype.Shared.Services
{
    public class MailService
    {
        public MailService() { }

        public async Task<List<MailDto>> GetAllMailsAsync()
        {
            await Task.Delay(1000);

            return Allails();
        }

        public async Task<MailDto> GetMailByIdAsync(int id)
        {
            await Task.Delay(1000);
            return Allails().FirstOrDefault(email => email.Id == id) ?? new MailDto();
        }

        private List<MailDto> Allails()
        {
            return new List<MailDto>
            {
                new MailDto { Id = 1, Subject = "202503248081", Branch = "Allgemein", Date = DateTime.Now, SentBy = "User A", Area = "Allgemein", Message = "This is a test email message.", IsRead = false },
                new MailDto { Id = 2, Subject = "202503248081", Branch = "Allgemein", Date = DateTime.Now, SentBy = "User A", Area = "Allgemein", Message = "This is a test email message.", IsRead = false },
                new MailDto { Id = 3, Subject = "202503248081", Branch = "Allgemein", Date = DateTime.Now, SentBy = "User A", Area = "Allgemein", Message = "This is a test email message.", IsRead = false },
                new MailDto { Id = 4, Subject = "202503248081", Branch = "Allgemein", Date = DateTime.Now, SentBy = "User A", Area = "Allgemein", Message = "This is a test email message.", IsRead = false },
                new MailDto { Id = 5, Subject = "202503248081", Branch = "Allgemein", Date = DateTime.Now, SentBy = "User A", Area = "Allgemein", Message = "This is a test email message.", IsRead = false },
                new MailDto { Id = 6, Subject = "202503248081", Branch = "Allgemein", Date = DateTime.Now, SentBy = "User B", Area = "Allgemein", Message = "This is a test email message.", IsRead = false },
                new MailDto { Id = 7, Subject = "202503248081", Branch = "Allgemein", Date = DateTime.Now, SentBy = "User B", Area = "Allgemein", Message = "This is another test email message.", IsRead = true }
            };
        }

    }
}
