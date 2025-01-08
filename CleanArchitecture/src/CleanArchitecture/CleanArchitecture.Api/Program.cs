using CleanArchitecture.Application;
using CleanArchitecture.Infrastructure;
using CleanArchitecturte.Api.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.ApplyMigration();
app.MapControllers();
app.SeedData();
app.UseCustomExceptionHandler();

app.MapControllers();


app.Run();
