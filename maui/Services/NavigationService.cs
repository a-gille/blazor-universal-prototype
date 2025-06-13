using blazor_universal_maui_prototype.State;
using blazor_universal_prototype.Shared.Services;
namespace blazor_universal_maui_prototype.Services
{
    internal class NavigationService : INavigationService
    {
        private readonly StateService _state;
        public NavigationService(StateService state)
        {
            _state = state;
        }

        public async Task SelectMail(int id)
        {
            _state.MailId = id;
            await Shell.Current.GoToAsync($"/maildetail");
        }

        public async Task SelectSendMail()
        {
            await Shell.Current.GoToAsync("/send");
        }
    }
}
