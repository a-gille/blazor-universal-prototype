using blazor_universal_prototype.Services;
using blazor_universal_prototype.Shared.Services;
using blazor_universal_prototype.Shared.ViewModels;
using Microsoft.Extensions.Logging;
using Microsoft.FluentUI.AspNetCore.Components;

namespace blazor_universal_prototype
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
                });
            builder.Services.AddFluentUIComponents();
            // Add device-specific services used by the blazor_universal_prototype.Shared project
            builder.Services.AddSingleton<IFormFactor, FormFactor>();
            builder.Services.AddSingleton<MailService>();
            builder.Services.AddSingleton<AttachmentService>();
            builder.Services.AddScoped<HomeViewModel>();
            builder.Services.AddSingleton<MailDetailViewModel>();
            builder.Services.AddSingleton<SendViewModel>();

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
