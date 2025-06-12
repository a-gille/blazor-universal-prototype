namespace blazor_universal_prototype.Shared.Services
{
    public interface INavigationService
    {
        Task SelectMail(int id);

        Task SelectSendMail();
    }
}
