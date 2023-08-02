using CletusReyes.Models.Domain_Model.Category;
using CletusReyes.Models.Domain_Model.Provider;
using CletusReyes.Models.Domain_Model.Size;
using CletusReyes.Models.Domain_Model.Unit_Measure;
using Microsoft.EntityFrameworkCore;

namespace CletusReyes.Data
{
    public class CletusReyesDataDbContext : DbContext
    {
        public CletusReyesDataDbContext(DbContextOptions<CletusReyesDataDbContext> dbContextOptions) : base(dbContextOptions)
        {
            
        }

        public DbSet<TblSize> Sizes { get; set; }
        public DbSet<TblCategory> Categories { get; set; }
        public DbSet<TblUnitMeasure> UnitMeasures { get; set; }
        public DbSet<TblProvider> Providers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed data for Sizes
            var sizes = new List<TblSize>()
            {
                new TblSize()
                {
                    Id = Guid.Parse("4847982e-f6e4-4d30-acfa-d4d3eb774025"),
                    Size = "12oz",
                    Status = true
                },
                new TblSize()
                {
                    Id = Guid.Parse("1afcad04-bae2-4edd-a936-7eea79380149"),
                    Size = "14oz",
                    Status = true
                },
                new TblSize()
                {
                    Id = Guid.Parse("24d0f481-814c-41b3-b0d8-4c875d89a95d"),
                    Size = "16oz",
                    Status = true
                }
            };
            modelBuilder.Entity<TblSize>().HasData(sizes);
        }
    }
}
