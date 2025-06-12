using blazor_universal_prototype.Shared.Services;
using blazor_universal_prototype.Shared.ViewModels;
using Microsoft.Extensions.Logging;

namespace maui_prototype
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
            builder.Services.AddScoped<HomeViewModel>();
            builder.Services.AddSingleton<MailDetailViewModel>();
            builder.Services.AddSingleton<SendViewModel>();


#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
