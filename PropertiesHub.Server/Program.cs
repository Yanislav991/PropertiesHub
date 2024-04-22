using PropertiesHub.Server.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

var app = builder.Build();

builder.RegisterServices();

app.UseHttpsRedirection().UseAuthorization();
app.MapControllers();
app.Run();