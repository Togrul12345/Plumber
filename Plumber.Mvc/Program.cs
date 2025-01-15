using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Plumber.Bl.Dtos;
using Plumber.Bl.Profiles;
using Plumber.Bl.Services.Abstraction;
using Plumber.Bl.Services.Implementation;
using Plumber.Bl.Validators;
using Plumber.Core;
using Plumber.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews() ;
builder.Services.AddValidatorsFromAssembly(typeof(CreateAdminUserValidator).Assembly);
builder.Services.AddFluentValidationAutoValidation().AddFluentValidationClientsideAdapters();


builder.Services.AddAutoMapper(typeof(AdminUserProfile));
builder.Services.AddScoped<IIdentityService, IdentityService>();

builder.Services.AddIdentity<AdminUser, IdentityRole>(opt =>
{
    opt.Password.RequiredUniqueChars = 0;
    opt.Password.RequireNonAlphanumeric = false;
    opt.Password.RequireDigit = false;
    opt.Password.RequireLowercase = false;
    opt.Password.RequireUppercase = false;
    opt.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+/ ";
  

}).AddEntityFrameworkStores<PlumberDbContext>().AddDefaultTokenProviders();
builder.Services.AddDbContext<PlumberDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("Hp"));
});
var app = builder.Build();
app.MapControllerRoute(
           name: "area",
           pattern: "{area:exists}/{controller=Admin}/{action=Index}/{id?}"
         );
app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
app.UseStaticFiles();



app.Run();
