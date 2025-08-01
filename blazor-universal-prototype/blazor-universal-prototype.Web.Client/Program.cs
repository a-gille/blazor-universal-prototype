using blazor_universal_maui_prototype.Web.Client.Services;
using blazor_universal_prototype.Shared.Services;
using blazor_universal_prototype.Shared.ViewModels;
using blazor_universal_prototype.Web.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.FluentUI.AspNetCore.Components;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddFluentUIComponents();
// Add device-specific services used by the blazor_universal_prototype.Shared project
builder.Services.AddScoped<INavigationService, NavigationService>();
builder.Services.AddSingleton<IAddAttachmentService, AddAttachmentService>();
builder.Services.AddSingleton<MailService>();
builder.Services.AddSingleton<AttachmentService>();
builder.Services.AddScoped<HomeViewModel>();
builder.Services.AddSingleton<MailDetailViewModel>();
builder.Services.AddSingleton<SendViewModel>();

await builder.Build().RunAsync();
