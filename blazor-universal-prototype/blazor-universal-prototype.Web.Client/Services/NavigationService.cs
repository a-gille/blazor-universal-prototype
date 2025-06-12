using blazor_universal_prototype.Shared.Services;
using Microsoft.AspNetCore.Components;
namespace blazor_universal_prototype.Web.Client.Services
{
    public partial class NavigationService : INavigationService
    {
        private NavigationManager _navigationManager;
        public NavigationService(NavigationManager navigationManager)
        {
            _navigationManager = navigationManager;
        }

        public Task SelectMail(int id)
        {
            _navigationManager.NavigateTo($"/maildetail/{id}");
            return Task.CompletedTask;
        }
        public Task SelectSendMail()
        {
            _navigationManager.NavigateTo("/send");
            return Task.CompletedTask;
        }
    }
}
