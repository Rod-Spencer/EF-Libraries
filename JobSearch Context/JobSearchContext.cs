using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SpenSoft.Job_Search.Objects;

namespace SpenSoft.EF.JobSearch;

public class JobSearchContext : DbContext
{
    public JobSearchContext(DbContextOptions<JobSearchContext> options)
        : base(options)
    {
    }
    public JobSearchContext()
    {
    }

    public DbSet<Activities> Activities { get; set; }
    public DbSet<ActivityStatus> ActivityStatus { get; set; }
    public DbSet<ActivityStatuses> ActivityStatuses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        IConfigurationRoot config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.JobSearch.json")
            .Build();

        String? name = "JobSearchConnection";
        var connection = config.GetConnectionString(name);
        if (String.IsNullOrEmpty(connection) == false)
        {
            optionsBuilder.UseSqlServer(connection);
        }
    }

}
