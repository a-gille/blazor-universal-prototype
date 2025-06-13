
namespace blazor_universal_maui_prototype.Pages
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("maildetail", typeof(MailDetailPage));
        }
    }
}
