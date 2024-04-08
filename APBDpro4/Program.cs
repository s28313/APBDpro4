using APBDpro4;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
//Animals
app.MapGet("/api/Animals", () =>
    {
        var animals = DataBase.Animals;
        return Results.Ok(animals);
    }
);

app.MapGet("/api/Animals/{ id:int }", ([FromRoute] int id) =>
{
    var animal = DataBase.Animals.FirstOrDefault(a => a.Id == id);
    return animal is null ? Results.NotFound($"Animal with id {id} not found") : Results.Ok(animal);
});

//Visits
app.MapGet("/api/Visits", () =>
    {
        var visits = DataBase.Visits;
        return Results.Ok(visits);
    }
);

app.MapGet("/api/Visits/{ id:int }", ([FromRoute] int id) =>
{
    List<Visit> visits = new List<Visit>();
    foreach (var VARIABLE in DataBase.Visits)
    {
        if (VARIABLE.AnimalId == id) visits.Add(VARIABLE);
    }
    
    return visits.Count != 0 ? Results.NotFound($"Animal with id {id} has no visits") : Results.Ok(visits);
});

app.Run();

