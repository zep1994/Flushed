using AutoMapper;
using Flushed_API.Data;
using Flushed_API.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(opt =>
    opt.UseNpgsql(builder.Configuration.GetConnectionString("PostgresConnection")));

builder.Services.AddScoped<INutritionRepo, NutritionRepo>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();


//app.UseHttpsRedirection();


app.MapGet("api/nutrition", async (INutritionRepo repo, IMapper mapper) =>
{
    var nutrition = await repo.GetAllNutritions();
    return Results.Ok(mapper.Map<IEnumerable<Nutrition>>(nutrition));
});

//GET
app.MapGet("api/ibs_count", async (AppDbContext context) =>
{

    return Results.Ok(await context.IbsCount.Where(b => b.Count >= 1).ToListAsync());
});

//POST
app.MapPost("api/ibs_count", async (AppDbContext context, IbsCount ibsCount) =>
{
    await context.IbsCount.AddAsync(ibsCount);
    await context.SaveChangesAsync();

    return Results.Created($"api/ibs_count/{ibsCount.Id}", ibsCount);
});

//UPDATE
app.MapPut("api/ibs_count/{id}", async (AppDbContext context, int id, IbsCount ibsCount) =>
{
    var ibsModel = await context.IbsCount.FirstOrDefaultAsync(x => x.Id == id);

    if (ibsModel == null)
    {
        return Results.NotFound();
    }

    ibsModel.Count = ibsCount.Count;
    await context.SaveChangesAsync();

    return Results.NoContent();

});

//DELETE
app.MapDelete("api/ibs_count/{id}", async (AppDbContext context, int id) =>
{
    var ibsModel = await context.IbsCount.FirstOrDefaultAsync(x => x.Id == id);

    if (ibsModel == null)
    {
        return Results.NotFound();
    }

    context.IbsCount.Remove(ibsModel);

    await context.SaveChangesAsync();

    return Results.NoContent();
});

//GET INGREDIENT INFO
//app.MapGet("https://api.edamam.com/api/nutrition-data?app_id=bde1907b&app_key=e6dc9e1a571e8e55c6335225a3c217b8&nutrition-type=cooking&ingr=beef", async () =>
//{
//    await Results.NoContent();
//    return
//})

app.Run();
 
