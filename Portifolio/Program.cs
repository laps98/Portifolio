using Microsoft.EntityFrameworkCore;
using Portifolio.Context;
using Portifolio.Domain.Context;

var builder = WebApplication.CreateBuilder(args);
var service = builder.Services;

// adicione as linhas abaixo dentro da função que já existe
var connection = builder.Configuration["ConectionString:DefaultConnection"];
service.AddDbContext<AreaDbContext>(options =>
{
    options.UseMySql(connection, ServerVersion.AutoDetect(connection));
});
service.AddScoped<IAreaDbContext, AreaDbContext>();

builder.Services.AddControllersWithViews();
builder.Services.AddControllers();


var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Home/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
