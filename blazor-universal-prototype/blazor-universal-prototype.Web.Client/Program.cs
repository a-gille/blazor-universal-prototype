using blazor_universal_prototype.Shared.Services;
using blazor_universal_prototype.Shared.ViewModels;
using blazor_universal_prototype.Web.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.FluentUI.AspNetCore.Components;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddFluentUIComponents();
// Add device-specific services used by the blazor_universal_prototype.Shared project
builder.Services.AddSingleton<IFormFactor, FormFactor>();
builder.Services.AddSingleton<MailService>();
builder.Services.AddSingleton<AttachmentService>();
builder.Services.AddSingleton<HomeViewModel>();
builder.Services.AddSingleton<MailDetailViewModel>();
builder.Services.AddSingleton<SendViewModel>();

await builder.Build().RunAsync();
