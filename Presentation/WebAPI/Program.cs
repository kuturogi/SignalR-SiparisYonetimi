using Application;
using Persistence;
using Persistence.Context;
using WebAPI.Hubs;

var builder = WebApplication.CreateBuilder(args);

//apin�n bizim istedi�imiz s�n�rlar i�erisinde d��ar�ya a��lmas�n� sa�layan y�ntem
builder.Services.AddCors(opt =>
{
	opt.AddPolicy("CorsPolicy", builder =>
	{
		builder.AllowAnyHeader().AllowAnyMethod().SetIsOriginAllowed((host) => true).AllowCredentials();
	});
});

builder.Services.AddSignalR();

// Add services to the container.

builder.Services.AddPersistenceServices(builder.Configuration);
builder.Services.AddApplicationServices();

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

app.UseCors("CorsPolicy");

app.UseAuthorization();

app.MapControllers();

app.MapHub<SignalRHub>("/signalrhub");

app.Run();
