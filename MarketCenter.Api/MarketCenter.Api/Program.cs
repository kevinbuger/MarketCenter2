using MarketCenter.Api.Extensions;
using MarketCenter.Infrastructure.Persistence;
using MassTransit;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();




// Add MassTransit Configuration




var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.MigrateDatabase<MarketCenterContext>((context, services) =>
{
    var logger = services.GetService<ILogger<MarketCenterContextSeed>>();
    MarketCenterContextSeed.SeedAsync(context, logger).Wait();
});
app.Run();
