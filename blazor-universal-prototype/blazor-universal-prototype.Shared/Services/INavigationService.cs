namespace blazor_universal_prototype.Shared.Services
{
    public interface INavigationService
    {
        Task NavigateToMailDetail(int id);

        Task NavigateToSendMail();
    }
}
