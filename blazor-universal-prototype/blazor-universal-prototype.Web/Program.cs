using blazor_universal_maui_prototype.Web.Services;
using blazor_universal_prototype.Shared.Services;
using blazor_universal_prototype.Shared.ViewModels;
using blazor_universal_prototype.Web.Components;
using blazor_universal_prototype.Web.Services;
using Microsoft.FluentUI.AspNetCore.Components;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddFluentUIComponents();
// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveWebAssemblyComponents();

// Add device-specific services used by the blazor_universal_prototype.Shared project
builder.Services.AddScoped<INavigationService, NavigationService>();
builder.Services.AddSingleton<IAddAttachmentService, AddAttachmentService>();
builder.Services.AddSingleton<MailService>();
builder.Services.AddSingleton<AttachmentService>();
builder.Services.AddScoped<HomeViewModel>();
builder.Services.AddSingleton<MailDetailViewModel>();
builder.Services.AddSingleton<SendViewModel>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(
        typeof(blazor_universal_prototype.Shared._Imports).Assembly,
        typeof(blazor_universal_prototype.Web.Client._Imports).Assembly);

app.Run();
