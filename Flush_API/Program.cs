using Flushed_API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>(opt =>
    opt.UseNpgsql(builder.Configuration.GetConnectionString("PostgresConnection")));

builder.Services.AddScoped<INutritionRepo, NutritionRepo>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

// Configure the HTTP request pipeline.

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
