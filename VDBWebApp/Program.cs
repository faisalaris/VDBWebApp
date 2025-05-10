using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using VDBWebApp;
using VDBWebApp.Services;
using Radzen;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddBlazoredLocalStorage(); // Tambahkan ini untuk mengaktifkan LocalStorage
builder.Services.AddScoped(sp =>
{
    var client = new HttpClient { BaseAddress = new Uri("https://apivbd.duckdns.org/api/main") }; 
    client.DefaultRequestHeaders.Add("TokenId", "240782");
    client.DefaultRequestHeaders.Add("SenderId", "WKSP");
    client.DefaultRequestHeaders.Add("TransmitUniqueId", "12345");
    client.DefaultRequestHeaders.Add("UserId", "KSP");
    client.DefaultRequestHeaders.Add("RequestType", "Q");
    return client;
});

builder.Services.AddScoped<LoginServices>();
builder.Services.AddScoped<DashboardServices>();
builder.Services.AddScoped<ProductServices>();
builder.Services.AddScoped<GensetServices>();
builder.Services.AddScoped<CustomerServices>();
builder.Services.AddScoped<OrderServices>();

builder.Services.AddScoped<DialogService>();
builder.Services.AddScoped<NotificationService>();
builder.Services.AddScoped<TooltipService>();
builder.Services.AddScoped<ContextMenuService>();

builder.Services.AddMudServices();

await builder.Build().RunAsync();
