using blazor_universal_prototype.Shared.Services;
using Microsoft.AspNetCore.Components;
namespace blazor_universal_prototype.Services
{
    public partial class NavigationService : INavigationService
    {
        private NavigationManager _navigationManager;
        public NavigationService(NavigationManager navigationManager)
        {
            _navigationManager = navigationManager;
        }

        public Task NavigateToMailDetail(int id)
        {
            _navigationManager.NavigateTo($"/maildetail?id={id}");
            return Task.CompletedTask;
        }
        public Task NavigateToSendMail()
        {
            _navigationManager.NavigateTo("/send");
            return Task.CompletedTask;
        }
    }
}
