using blazor_universal_prototype.Shared.Services;
using blazor_universal_prototype.Shared.ViewModels;
using Microsoft.Extensions.Logging;

namespace maui
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
            builder.Services.AddSingleton<MailService>();
            builder.Services.AddSingleton<AttachmentService>();
            builder.Services.AddSingleton<MailDetailViewModel>();
            builder.Services.AddSingleton<SendViewModel>();
            builder.Services.AddSingleton<HomeViewModel>();

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
