using GYM.Business.Abstract;
using GYM.Business.Concrete;
using GYM.DataAccessLayer;
using GYM.DataAccessLayer.Abstract;
using GYM.DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<GymDbContext>();
builder.Services.AddSwaggerDocument(config =>
{
    config.PostProcess = (doc =>
    {
        doc.Info.Title = "ALL HOTEL API";
        doc.Info.Version = "1.0.13";
        doc.Info.Contact = new NSwag.OpenApiContact()
        {
            Name = "Aykut TOPRAK",
            Url = "https://www.google.com",
            Email = "aykut@gmail.com"
        };
    });
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //app.UseSwagger();
    //app.UseSwaggerUI();
}

app.UseRouting();

app.UseOpenApi();

app.UseSwaggerUi3();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
