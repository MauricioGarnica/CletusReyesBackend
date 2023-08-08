using CletusReyes.Models.Domain_Model.Category;
using CletusReyes.Models.Domain_Model.Product;
using CletusReyes.Models.Domain_Model.Provider;
using CletusReyes.Models.Domain_Model.Raw_Material;
using CletusReyes.Models.Domain_Model.Recipe;
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
        public DbSet<TblRawMaterial> RawMaterials { get; set; }
        public DbSet<TblProduct> Products { get; set; }
        public DbSet<TblRecipeHeader> RecipeHeaders { get; set; }
        public DbSet<TblRecipeDetail> RecipeDetails { get; set; }

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

            //Seed data for Unit Measures
            var unitMeasures = new List<TblUnitMeasure>()
            {
                new TblUnitMeasure()
                {
                    Id = Guid.Parse("92743A31-78D1-4E8A-EB94-08DB979FE8CB"),
                    Name = "CM",
                    Status = true
                },
                new TblUnitMeasure()
                {
                    Id = Guid.Parse("7220FD18-43FE-4880-EB95-08DB979FE8CB"),
                    Name = "PZ",
                    Status = true
                }
            };
            modelBuilder.Entity<TblUnitMeasure>().HasData(unitMeasures);

            //Seed data for Categories
            var categories = new List<TblCategory>()
            {
                new TblCategory()
                {
                    Id = Guid.Parse("ffbf969b-36bb-47b3-a3ee-840523779c01"),
                    Name = "Guantes",
                    Status = true
                },
                new TblCategory()
                {
                    Id = Guid.Parse("3f98d5d2-f4be-4e0a-9b07-07f212973b0d"),
                    Name = "Proteccion",
                    Status = true
                },
                new TblCategory()
                {
                    Id = Guid.Parse("68598c64-99c6-487c-b0f8-c0044c137596"),
                    Name = "Costales de box",
                    Status = true
                },
                new TblCategory()
                {
                    Id = Guid.Parse("f63758e5-61e2-4bf3-925c-0cf137216fe6"),
                    Name = "Coaching",
                    Status = true
                },
                new TblCategory()
                {
                    Id = Guid.Parse("35e3e543-5807-4805-890e-1d257fbeeee7"),
                    Name = "Ropa y calzado",
                    Status = true
                }
            };
            modelBuilder.Entity<TblCategory>().HasData(categories);
        }
    }
}
