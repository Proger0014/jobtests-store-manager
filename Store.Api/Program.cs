using Microsoft.EntityFrameworkCore;
using Store.Model.Enum;
using Store.Model.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<Persistence>(b => 
    b.UseNpgsql(
        builder.Configuration.GetConnectionString("Postgres"),
        o => o
            .MapEnum<Signature>("signature")
            .MapEnum<Status>("status")));

var app = builder.Build();

await app.Services.UseMigrationsAsync();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

await app.RunAsync();