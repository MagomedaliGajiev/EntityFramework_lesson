using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace EntityFramework_lesson;

public class ApplicationDbContext : DbContext
{
    public DbSet<Phone> Phones { get; set; }
    public DbSet<Guarantee> Guarantees { get; set; }
    public DbSet<App> Apps { get; set; }
    public DbSet<SoftwareUpdate> SoftwareUpdates { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();

        var connectionString = config.GetConnectionString("DefaultConnection");
        optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
                      .LogTo(Console.WriteLine, LogLevel.Information);
    }
}
