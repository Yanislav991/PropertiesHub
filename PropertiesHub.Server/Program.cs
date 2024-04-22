using Microsoft.EntityFrameworkCore;
using PropertiesHub.Server.Data;
using PropertiesHub.Server.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<PropertiesHubDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.RegisterServices();

var app = builder.Build();

app.UseHttpsRedirection().UseAuthorization();
app.MapControllers();
app.Run();