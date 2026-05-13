using BlazorApp_Bootstrap.Infrastructure;
using BlazorApp_Bootstrap.Interface;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// - injection de dépendance au niveau de l'assembly il faut le rajouter aussi sinon erreur javascript
builder.Services.AddTransient<IManageForm, MemoryManageForm>();

await builder.Build().RunAsync();
