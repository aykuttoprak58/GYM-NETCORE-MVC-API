using GYM.Business.Asyn.Abstract;
using GYM.Business.Asyn.Concrete;
using GYM.DataAccessLayer.Asyn;
using GYM.DataAccessLayer.Asyn.Abstract;
using GYM.DataAccessLayer.Asyn.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<GymDbContextAsyn>();

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

app.MapControllerRoute(
    name: "default",
   pattern: "{controller=User}/{action=Listele}/{id?}");

app.Run();
