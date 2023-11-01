using Backend.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllers();

    var connectionString = builder.Configuration.GetConnectionString("Connection"); 
    builder.Services.AddInfrastructure(connectionString);
}

var app = builder.Build();
{
    app.MapControllers();
    app.Run();
}