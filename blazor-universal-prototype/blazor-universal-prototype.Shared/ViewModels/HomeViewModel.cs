using System.Collections.ObjectModel;
using blazor_universal_prototype.Shared.Models;
using blazor_universal_prototype.Shared.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.AspNetCore.Components;

namespace blazor_universal_prototype.Shared.ViewModels
{
    public partial class HomeViewModel : ObservableObject
    {
        private readonly MailService _mailService;
        private readonly NavigationManager _navigationManager;
        public HomeViewModel(MailService mailService, NavigationManager navigationManager)
        {
            _mailService = mailService;
            _navigationManager = navigationManager;
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
        private async Task<bool> RefreshMails()
        {
            Mails.Clear();
            await LoadMails();
            return true;
        }

    }
}
