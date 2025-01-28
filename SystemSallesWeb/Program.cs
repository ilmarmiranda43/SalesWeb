using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System.Configuration;
using SystemSallesWeb.Data;
using SystemSallesWeb.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<SystemSallesWebContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("SystemSallesWebContext") ?? throw new InvalidOperationException("Connection string 'SystemSallesWebContext' not found."), new MySqlServerVersion(new Version (8, 0, 2))));
    //options.UseMySql(builder.Configuration.GetConnectionString("SalesWebMvcContext"), builder =>
    //builder.MigrationsAssembly("SalesWebMvc")));


// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<SeedingService>();

builder.Services.AddScoped<SellerService>();

builder.Services.AddScoped<DepartmentService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

using (var scope = app.Services.CreateScope())
{
    var seedingService = scope.ServiceProvider.GetRequiredService<SeedingService>();
    seedingService.Seed(); // Substitua "Seed" pelo nome do método que deseja chamar
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
