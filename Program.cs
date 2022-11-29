using CMS_Resort.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var corsPolicyName = "MyPolicy";
builder.Services.AddCors(options =>
{
	options.AddPolicy(name: corsPolicyName,
		policy => policy.WithOrigins("http://localhost:3000")
						.AllowAnyHeader()
						.AllowAnyMethod()
						.AllowCredentials()
	);
});

builder.Services.AddControllers();
builder.Services.AddDbContext<DataContext>();
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

app.UseCors(corsPolicyName);

app.UseAuthorization();

app.MapControllers();

app.Run();
