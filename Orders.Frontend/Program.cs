using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Orders.Frontend;
using Orders.Frontend.Repositories;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

<<<<<<< HEAD
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7293/") }); builder.Services.AddScoped<IRepository, Repository>();
=======
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7201/") }); builder.Services.AddScoped<IRepository, Repository>();
>>>>>>> 517741337a7a6f92256f196066d42eff85d94aa9


await builder.Build().RunAsync();
