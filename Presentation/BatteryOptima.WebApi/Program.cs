using BatteryOptima.Application.Interfaces;
using BatteryOptima.Application.Interfaces.BatteryCellInterfaces;

using BatteryOptima.Application.Interfaces.CellDetailInterfaces;
using BatteryOptima.Application.Interfaces.StatisticsInterfaces;
using BatteryOptima.Application.Interfaces.UseACellInterfaces;
using BatteryOptima.Application.Services;
using BatteryOptima.Persistence.Repositories;
using BatteryOptima.Persistence.Repositories.BatteryCellRepository;

using BatteryOptima.Persistence.Repositories.CellDetailRepository;
using BatteryOptima.Persistence.Repositories.StatisticsRepository;
using BatteryOptima.Persistence.Repositories.UseACellRepository;
using ProductionOptima.Persistence.Context;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddHttpClient();

builder.Services.AddScoped<ProductionOptimaContext>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped(typeof(IBatteryCellRepository), typeof(BatteryCellRepository));
builder.Services.AddScoped(typeof(ICellDetailRepository), typeof(CellDetailRepository));
builder.Services.AddScoped(typeof(IStatisticsRepository), typeof(StatisticsRepository));
builder.Services.AddScoped(typeof(IUseACellRepository), typeof(UseACellRepository));


builder.Services.AddApplicationService(builder.Configuration);

builder.Services.AddControllers();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
