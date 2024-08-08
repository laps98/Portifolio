using Microsoft.EntityFrameworkCore;
using Portifolio.Context;
using Portifolio.Domain.Context;

var builder = WebApplication.CreateBuilder(args);
var service = builder.Services;

var connection = builder.Configuration["ConnectionStrings:DefaultConnection"];
service.AddDbContext<AreaDbContext>(options =>
{
    options.UseMySql(connection, ServerVersion.AutoDetect(connection));
});

service.AddTransient<IAreaDbContext, AreaDbContext>();
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();
builder.Services.AddControllers();


var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
