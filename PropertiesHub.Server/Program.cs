using Microsoft.EntityFrameworkCore;
using PropertiesHub.Server.Data;
using PropertiesHub.Server.Services.Contracts;
using PropertiesHub.Server.Services;
using AutoMapper;
using PropertiesHub.Server.Profiles;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<PropertiesHubDbContext>(options =>
{
    options.UseSqlServer(connectionString);
    
});

builder.Services.AddScoped<IPropertyService, PropertyService>();

builder.Services.AddSingleton(new MapperConfiguration(mc =>
{
    mc.AddProfile<PropertiesProfile>();
}).CreateMapper());

var app = builder.Build();
// Avoid migrating database manually
app.Services.CreateScope().ServiceProvider.GetService<PropertiesHubDbContext>()?.Database.Migrate();

app.UseHttpsRedirection().UseAuthorization();
app.MapControllers();
app.Run();