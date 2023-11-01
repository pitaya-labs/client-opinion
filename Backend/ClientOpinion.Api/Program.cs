using Backend.Infrastructure.Common;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddDbContext<BackendContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Connection"),
        x => x.MigrationsAssembly("ClientOpinion.Infrastructure"));
});

var app = builder.Build();
app.MapControllers();


app.Run();