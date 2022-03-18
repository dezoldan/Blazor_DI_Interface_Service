using Blazor_DI_Interface_Service.Server;
using Blazor_DI_Interface_Service.Server.BaseServices;
using Blazor_DI_Interface_Service.Server.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddServerSideBlazor();

//para fins didáticos, coloque a sua connectionString abaixo
string _connectionString = null!;
_connectionString = "sua connectionString";
builder.Services.AddDbContext<DataContext>(options => { options.UseSqlServer(_connectionString); });

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddScoped<IBaseService, BaseService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
