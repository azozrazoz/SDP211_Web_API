using Microsoft.EntityFrameworkCore;
using SDP211_Web_API.Models;
using System.Configuration;
using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddMvcCore();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Version = "v1",
        Title = "Weather API",
        Description = "This is weather forecast example for student IT Step",
        TermsOfService = new Uri("https://learn.microsoft.com/"),
        Contact = new Microsoft.OpenApi.Models.OpenApiContact
        {
            Name = "Doshan",
            Email = "doshan@gmail.com",
            Url = new Uri("https://learn.microsoft.com/"),
        },
        License = new Microsoft.OpenApi.Models.OpenApiLicense
        {
            Name = "Weather Forecast Open license",
            Url = new Uri("https://learn.microsoft.com/"),
        }
    });
});

/*builder.Services.AddDbContext<WeatherContext>(options =>
        options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));*/

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseSwagger();
app.UseSwaggerUI(c => {
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    c.RoutePrefix = string.Empty; });

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseAuthorization();

app.MapControllers();

app.Run();
