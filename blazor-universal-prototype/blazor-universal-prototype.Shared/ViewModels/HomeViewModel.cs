using System.Collections.ObjectModel;
using blazor_universal_prototype.Shared.Models;
using blazor_universal_prototype.Shared.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace blazor_universal_prototype.Shared.ViewModels
{
    public partial class HomeViewModel : ObservableObject
    {
        private readonly MailService _mailService;
        public HomeViewModel(MailService mailService)
        {
            _mailService = mailService;
        }

        [ObservableProperty]
        private ObservableCollection<MailDto> _mails = new();

        [RelayCommand]
        private async Task LoadMails()
        {
            var mails = await _mailService.GetAllMailsAsync();
            foreach (var mail in mails)
            {
                if (!Mails.Select(m => m.Id).Contains(mail.Id))
                {
                    Mails.Add(mail);
                }
            }
        }

        [RelayCommand]
        private async Task SelectMail(int id)
        {
            //await Shell.Current.GoToAsync($"MailDetailPage?id={id}");
        }

        [RelayCommand]
        private async Task SelectSendMail()
        {
            //await Shell.Current.GoToAsync("SendPage");
        }

    }
}
