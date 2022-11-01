var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options => {options.IdleTimeout = TimeSpan.FromMinutes(30);});

var app = builder.Build();
app.UseStaticFiles();
app.UseRouting();
app.UseSession();

app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute(name: "doctor", pattern: "fevercheck", defaults: new {controller = "Doctor", action = "Fevercheck"});
app.MapControllerRoute(name: "GuessingGame", pattern: "GuessingGame", defaults: new { controller = "GuessingGame", action = "GuessingGame" });


app.Run();
