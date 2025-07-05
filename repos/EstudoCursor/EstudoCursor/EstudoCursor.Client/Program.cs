using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using EstudoCursor.Client;
using EstudoCursor.Client.Domain.Interfaces;
using EstudoCursor.Client.Infrastructure.Repositories;
using EstudoCursor.Client.Application.Services;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Configurar serviços
builder.Services.AddScoped<IPessoaRepository, PessoaRepositoryInMemory>();
builder.Services.AddScoped<PessoaService>();

// Configurar MudBlazor
builder.Services.AddMudServices();

await builder.Build().RunAsync();
