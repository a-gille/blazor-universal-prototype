using blazor_universal_maui_prototype.State;

namespace blazor_universal_maui_prototype.Pages;

public partial class MailDetailPage : ContentPage
{
    public MailDetailPage(StateService state)
    {
        InitializeComponent();
        root.Parameters = new Dictionary<string, object?>()
        {
            {"id", state.MailId}
        };
    }
}