using Microsoft.EntityFrameworkCore;
using WebAPIAndReact.Database;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Menambahkan semua controllers
builder.Services.AddControllers();

builder.Services.AddDbContext<DataContext>(options =>
{
	options.UseSqlite("FileName=./MyDatabase.db");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Add mapping controller
app.MapControllers();

app.Run();

