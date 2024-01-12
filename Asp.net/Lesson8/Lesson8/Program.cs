var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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

app.UseAuthorization();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "kamil/{controller=Home}/{action=Privacy}/{id?}");

//app.UseEndpoints(endpoints =>
//{
//    //endpoints.MapControllerRoute("custom3", "{controller}/{action}/{id:int?}/{b:length(5)?}/{c?}");
//    //endpoints.MapControllerRoute("custom2", "anasehife", new {controller = "Home", action = "index"});
//    //endpoints.MapControllerRoute("custom1", "{action}/kamil/{controller}");
//    endpoints.MapControllers();
//});
app.MapControllers();

app.Run();
