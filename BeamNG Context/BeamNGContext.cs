using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SpenSoft.BeamNG.VehicleObjects;

namespace SpenSoft.EF.BeamNG
{
    public class BeamNGContext : DbContext
    {
        public BeamNGContext(DbContextOptions<BeamNGContext> sc) : base(sc) { }
        public BeamNGContext() { }


        public DbSet<Vehicle>? Vehicles { get; set; }

        public DbSet<VConfiguration>? Configurations { get; set; }

        public DbSet<VehicleImage>? Images { get; set; }

        public DbSet<Classifications>? Classification { get; set; }

        public DbSet<BodyStyles>? Body_Style { get; set; }

        public DbSet<DriveTrain>? Drive_Train { get; set; }

        public DbSet<Countries>? Country { get; set; }

        public DbSet<ImagesData>? Images_Data { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.BeamNG.json")
                .Build();

            String? name = "BeamNGConnection";
            var connection = config.GetConnectionString(name);
            if (String.IsNullOrEmpty(connection) == false)
            {
                optionsBuilder.UseSqlServer(connection);
            }
        }

    }
}
