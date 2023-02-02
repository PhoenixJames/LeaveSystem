using Microsoft.EntityFrameworkCore;
using LeaveSystem.Entities;

public class Startup
{
    public IConfiguration Configuration { get; }

    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services) {
      var serverVersion = new MySqlServerVersion(new Version(8, 0, 28));
      services.AddDbContext<LeaveSystemContext>(
            dbContextOptions => dbContextOptions
                .UseMySql(Configuration.GetConnectionString("DefaultConnection"), serverVersion)
                .EnableSensitiveDataLogging() // <-- These two calls are optional but help
                .EnableDetailedErrors()
          );

    }
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
    }
}
