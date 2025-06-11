using System.Collections.ObjectModel;
using blazor_universal_prototype.Shared.Models;
using blazor_universal_prototype.Shared.Services;
using CommunityToolkit.Mvvm.ComponentModel;

namespace blazor_universal_prototype.Shared.ViewModels
{
    public partial class MailDetailViewModel : ObservableObject
    {
        private readonly MailService _emailService;
        private readonly AttachmentService _attachmentService;

        public MailDetailViewModel(MailService emailService, AttachmentService attachmentService)
        {
            _emailService = emailService;
            _attachmentService = attachmentService;
        }

        private int _mailId;

        [ObservableProperty]
        private MailDto _mail;

        [ObservableProperty]
        private ObservableCollection<AttachmentDto> _attachments = new();

        [ObservableProperty]
        private bool _hasNoAttachments = false;

        [ObservableProperty]
        private bool _isLoading = true;

        [ObservableProperty]
        private int _numberOfAttachments = 0;

        public async void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            HasNoAttachments = false;
            if (query.ContainsKey("id") && _mailId != int.Parse(query["id"] as string ?? "1"))
            {
                Attachments.Clear();
                NumberOfAttachments = Attachments.Count;
                IsLoading = true;
                _mailId = int.Parse(query["id"] as string ?? "1");

                var loadAttachmentsTask = LoadAttachmentsAsync();
                var getMailTask = _emailService.GetMailByIdAsync(_mailId);

                await Task.WhenAll(loadAttachmentsTask, getMailTask);

                Mail = await getMailTask;
                IsLoading = false;
            }
            NumberOfAttachments = Attachments.Count;
            if (Attachments.Count <= 0)
            {
                HasNoAttachments = true;
            }
        }

        private async Task LoadAttachmentsAsync()
        {
            var attachments = await _attachmentService.GetAttachmentByIdAsync(_mailId);
            foreach (var attachment in attachments)
            {
                Attachments.Add(attachment);
            }
        }
    }
}
