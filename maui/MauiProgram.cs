using blazor_universal_maui_prototype.Services;
using blazor_universal_maui_prototype.State;
using blazor_universal_prototype.Shared.Services;
using blazor_universal_prototype.Shared.ViewModels;
using Microsoft.Extensions.Logging;
using Microsoft.FluentUI.AspNetCore.Components;

namespace blazor_universal_maui_prototype
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

            builder.Services.AddFluentUIComponents();
            builder.Services.AddSingleton<StateService>();
            builder.Services.AddSingleton<IAddAttachmentService, AddAttachmentService>();
            builder.Services.AddScoped<INavigationService, NavigationService>();
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
