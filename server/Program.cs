using Microsoft.EntityFrameworkCore;
using LeaveSystem.Entities;
using LeaveSystem.IServices;
using LeaveSystem.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

// Database connection
var serverVersion = new MySqlServerVersion(new Version(8, 0, 28));
builder.Services.AddDbContext<LeaveSystemContext>(
      dbContextOptions => dbContextOptions
          .UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"), serverVersion)
          .EnableSensitiveDataLogging() // <-- These two calls are optional but help
          .EnableDetailedErrors()
);
builder.Services.AddHttpContextAccessor();
builder.Services.AddRazorPages();

builder.Services.AddTransient<IUtilityServices, UtilityServices>();
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();

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
