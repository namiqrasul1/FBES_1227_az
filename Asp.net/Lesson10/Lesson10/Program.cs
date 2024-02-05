using Lesson10.Data;
using Lesson10.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(op => op.UseSqlServer
    (
        builder.Configuration.GetConnectionString("Default"))
    );

builder.Services.AddIdentity<AppUser, IdentityRole>(options =>
{
    options.Password.RequiredUniqueChars = 5;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireDigit = false;
    options.Password.RequireUppercase = false;


})
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddAuthorization();

builder.Services.ConfigureApplicationCookie(options =>
{
    options.Cookie.Name = "YourCookiename";
    options.LoginPath = "/Account/Login";
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapAreaControllerRoute(
        name: "foradminarea",
        areaName: "Admin",
        pattern: "foradmin/{controller=Home}/{action=Index}"
        );

app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");


//var container = app.Services.CreateScope();
//var userManager = container.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
//var roleManager = container.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
//if (!await roleManager.RoleExistsAsync("Admin"))
//{
//    var result = await roleManager.CreateAsync(new IdentityRole("Admin"));
//    if (!result.Succeeded) throw new Exception(result.Errors.First().Description);
//}
//var user = await userManager.FindByEmailAsync("admin@admin.com");
//if (user is null)
//{
//    user = new AppUser
//    {
//        UserName = "admin@admin.com",
//        Email = "admin@admin.com",
//        FullName = "Admin",
//        Year = 2000,
//        EmailConfirmed = true
//    };
//    var result = await userManager.CreateAsync(user, "Admin12!");
//    if (!result.Succeeded) throw new Exception(result.Errors.First().Description);
//}

//await userManager.AddToRoleAsync(user, "Admin");


app.Run();
