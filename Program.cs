using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Blazor_Tarefas;
using Blazor_Tarefas.Servicos;
using Blazor_Tarefas.Repositorio;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// builder.Services.AddSingleton<ServicoSingleton>();
// builder.Services.AddScoped<ServicoScoped>();
// builder.Services.AddTransient<ServicoTransient>();

builder.Services.AddScoped<IRepositorio, Repositorio>();

await builder.Build().RunAsync();
