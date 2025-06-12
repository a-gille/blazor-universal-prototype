using blazor_universal_prototype.Shared.Services;
namespace blazor_universal_prototype.Services
{
    internal partial class NavigationService : INavigationService
    {
        public NavigationService()
        {
        }

        public async Task SelectMail(int id)
        {
            if (Shell.Current is not null)
            {
                await Shell.Current.GoToAsync($"/maildetail/{id}");
            }
            else
            {
                // Optional: Loggen oder Exception werfen
                Console.WriteLine("Shell.Current is null – navigation aborted.");
            }
        }

        public async Task SelectSendMail()
        {
            await Shell.Current.GoToAsync("/send");
        }
    }
}
