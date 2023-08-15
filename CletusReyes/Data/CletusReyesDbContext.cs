using CletusReyes.Models.Domain_Model.Auth;
using CletusReyes.Models.Domain_Model.Category;
using CletusReyes.Models.Domain_Model.Person;
using CletusReyes.Models.Domain_Model.Product;
using CletusReyes.Models.Domain_Model.Provider;
using CletusReyes.Models.Domain_Model.Purchase_Order;
using CletusReyes.Models.Domain_Model.Raw_Material;
using CletusReyes.Models.Domain_Model.Recipe;
using CletusReyes.Models.Domain_Model.Sale_Order;
using CletusReyes.Models.Domain_Model.Size;
using CletusReyes.Models.Domain_Model.Unit_Measure;
using Microsoft.EntityFrameworkCore;

namespace CletusReyes.Data
{
    public class CletusReyesDbContext : DbContext
    {
        public CletusReyesDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
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
        public DbSet<TblPurchaseOrderHeader> PurchaseOrderHeaders { get; set; }
        public DbSet<TblPurchaseOrderDetail> PurchaseOrderDetails { get; set; }
        public DbSet<TblPurchaseOrderStatus> PurchaseOrderStatus { get; set; }
        public DbSet<TblSaleOrderHeader> SaleOrderHeaders { get; set; }
        public DbSet<TblSaleOrderDetail> SaleOrderDetails { get; set; }
        public DbSet<TblSaleOrderStatus> SaleOrderStatus { get; set; }
        public DbSet<TblUser> Users { get; set; }
        public DbSet<TblPerson> Persons { get; set; }
        public DbSet<TblRoles> Roles { get; set; }
        public DbSet<TblUserRoles> UserRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TblUserRoles>().HasKey(userRole => new
            {
                userRole.RoleId,
                userRole.UserId
            });

            modelBuilder.Entity<TblUserRoles>()
                .HasOne(userRole => userRole.User)
                .WithMany(user => user.UserRoles)
                .HasForeignKey(userRole => userRole.UserId);

            modelBuilder.Entity<TblUserRoles>()
                .HasOne(userRole => userRole.Roles)
                .WithMany(role => role.UserRoles)
                .HasForeignKey(userRole => userRole.RoleId);

            //Seed data for Sizes
            var sizes = new List<TblSize>()
            {
                new TblSize()
                {
                    Id = Guid.Parse("4847982e-f6e4-4d30-acfa-d4d3eb774025"),
                    Size = "12oz",
                    Status = true,
                    Created_at = DateTime.Now.ToString("G")
                },
                new TblSize()
                {
                    Id = Guid.Parse("1afcad04-bae2-4edd-a936-7eea79380149"),
                    Size = "14oz",
                    Status = true,
                    Created_at = DateTime.Now.ToString("G")
                },
                new TblSize()
                {
                    Id = Guid.Parse("24d0f481-814c-41b3-b0d8-4c875d89a95d"),
                    Size = "16oz",
                    Status = true,
                    Created_at = DateTime.Now.ToString("G")
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
                    Status = true,
                    Created_at = DateTime.Now.ToString("G")
                },
                new TblUnitMeasure()
                {
                    Id = Guid.Parse("7220FD18-43FE-4880-EB95-08DB979FE8CB"),
                    Name = "PZ",
                    Status = true,
                    Created_at = DateTime.Now.ToString("G")
                }
            };
            modelBuilder.Entity<TblUnitMeasure>().HasData(unitMeasures);

            //Seed data for Categories
            var categories = new List<TblCategory>()
            {
                new TblCategory()
                {
                    Id = Guid.Parse("ffbf969b-36bb-47b3-a3ee-840523779c01"),
                    Name = "GUANTES",
                    Status = true,
                    Created_at = DateTime.Now.ToString("G")
                },
                new TblCategory()
                {
                    Id = Guid.Parse("3f98d5d2-f4be-4e0a-9b07-07f212973b0d"),
                    Name = "PROTECCION",
                    Status = true,
                    Created_at = DateTime.Now.ToString("G")
                },
                new TblCategory()
                {
                    Id = Guid.Parse("68598c64-99c6-487c-b0f8-c0044c137596"),
                    Name = "COSTALES DE BOX",
                    Status = true,
                    Created_at = DateTime.Now.ToString("G")
                },
                new TblCategory()
                {
                    Id = Guid.Parse("f63758e5-61e2-4bf3-925c-0cf137216fe6"),
                    Name = "COACHING",
                    Status = true,
                    Created_at = DateTime.Now.ToString("G")
                },
                new TblCategory()
                {
                    Id = Guid.Parse("35e3e543-5807-4805-890e-1d257fbeeee7"),
                    Name = "ROPA Y CALZADO",
                    Status = true,
                    Created_at = DateTime.Now.ToString("G")
                }
            };
            modelBuilder.Entity<TblCategory>().HasData(categories);

            //Seed data for Purchase Order Status
            var purchaseOrdersStatus = new List<TblPurchaseOrderStatus>()
            {
                new TblPurchaseOrderStatus
                {
                    Id = Guid.Parse("6967f493-61ef-41af-b785-a9a8649e8767"),
                    Name = "SOLICITADA",
                    Status = true,
                    Created_at = DateTime.Now.ToString("G")
                },
                new TblPurchaseOrderStatus
                {
                    Id = Guid.Parse("e2d2d115-764b-4264-a6a9-4a1f4d5f4dd4"),
                    Name = "EN CAMINO",
                    Status = true,
                    Created_at = DateTime.Now.ToString("G")
                },
                new TblPurchaseOrderStatus
                {
                    Id = Guid.Parse("5e257c72-e959-4d0d-9894-1c8682515a3a"),
                    Name = "ENTREGADA",
                    Status = true,
                    Created_at = DateTime.Now.ToString("G")
                },
                new TblPurchaseOrderStatus
                {
                    Id = Guid.Parse("196f0047-4231-4160-8d4e-124b8437dfac"),
                    Name = "CANCELADA",
                    Status = true,
                    Created_at = DateTime.Now.ToString("G")
                }
            };
            modelBuilder.Entity<TblPurchaseOrderStatus>().HasData(purchaseOrdersStatus);

            //Seed data for Sale Order Status
            var saleOrdersStatus = new List<TblSaleOrderStatus>()
            {
                new TblSaleOrderStatus
                {
                    Id = Guid.Parse("34e82473-b511-4b31-a94e-304130ee2ede"),
                    Name = "PEDIDO",
                    Created_at = DateTime.Now.ToString("G")
                },
                new TblSaleOrderStatus
                {
                    Id = Guid.Parse("bf341b19-7e2e-492e-8aef-ebab9c33fe09"),
                    Name = "ELABORANDO",
                    Created_at = DateTime.Now.ToString("G")
                },
                new TblSaleOrderStatus
                {
                    Id = Guid.Parse("aeb24d0e-7e62-4183-ace1-4401939ddce6"),
                    Name = "EMPACANDO",
                    Created_at = DateTime.Now.ToString("G")
                },
                new TblSaleOrderStatus
                {
                    Id = Guid.Parse("25a4b068-bc82-4684-8bc5-5c4087d487e4"),
                    Name = "ENVIANDO",
                    Created_at = DateTime.Now.ToString("G")
                },
                new TblSaleOrderStatus
                {
                    Id = Guid.Parse("d5f1c029-61cf-4273-a3d7-431c110e4f15"),
                    Name = "ENTREGADO",
                    Created_at = DateTime.Now.ToString("G")
                },
                new TblSaleOrderStatus
                {
                    Id = Guid.Parse("cb22b5ba-8792-4675-88bb-e33beb098b7d"),
                    Name = "CANCELADO",
                    Created_at = DateTime.Now.ToString("G")
},
            };
            modelBuilder.Entity<TblSaleOrderStatus>().HasData(saleOrdersStatus);

            //Seed data for Roles;
            var roles = new List<TblRoles>
            {
                new TblRoles
                {
                    Id = "31f16eb0-8649-4015-9edd-b179b461a2dd",
                    ConcurrencyStamp = "31f16eb0-8649-4015-9edd-b179b461a2dd",
                    Name = "Admin",
                    NormalizedName = "Admin".ToUpper()
                },
                new TblRoles
                {
                    Id = "f71926a4-5573-4a11-bb9c-875d856cd446",
                    ConcurrencyStamp = "f71926a4-5573-4a11-bb9c-875d856cd446",
                    Name = "Customer",
                    NormalizedName = "Customer".ToUpper()
                },
            };
            modelBuilder.Entity<TblRoles>().HasData(roles);

            //Seed data for providers
            var providers = new List<TblProvider>
            {
                new TblProvider
                {
                    Id = Guid.Parse("32a9172e-d7fd-4b44-83cc-48bfed5a80a1"),
                    Address = "Blvd. Torres Landa #3301 Col.Arroyo Hondo",
                    BusinessName = "Medina Torres",
                    ContactEmail = "info@medinatorres.com",
                    ContactName = "Juan Medina",
                    ContactPhone = "4777181780",
                    Created_at = DateTime.Now.ToString("G"),
                    Status = true,
                },
                new TblProvider
                {
                    Id = Guid.Parse("e1174f5b-5e16-4bc1-8c31-7e8e89e6022e"),
                    Address = "Monte Carmelo #112 Col.Arroyo Hondo",
                    BusinessName = "Curtiembres de México",
                    ContactEmail = "info@curtiembresdemexico.com",
                    ContactName = "Sebastian Perez",
                    ContactPhone = "4777780079",
                    Created_at = DateTime.Now.ToString("G"),
                    Status = true,
                },
                new TblProvider
                {
                    Id = Guid.Parse("cc1fa6e7-bee4-4e34-b427-f26ebb6314c8"),
                    Address = "Av.Transportistas #301 Col.Unidad Obrera",
                    BusinessName = "Lefarc",
                    ContactEmail = "mercadotecnia@lefarc.com",
                    ContactName = "Alonso Hernandez",
                    ContactPhone = "4774702828",
                    Created_at = DateTime.Now.ToString("G"),
                    Status = true,
                },
                new TblProvider
                {
                    Id = Guid.Parse("66398fad-6c5a-4608-9a3e-dc9b58be6cf5"),
                    Address = "Blvd.Timoteo Lozano #101-B Col.San Miguel",
                    BusinessName = "Simon Quimica",
                    ContactEmail = "ventassq@simonquimica.mx",
                    ContactName = "Erika Serrato",
                    ContactPhone = "4777705252",
                    Created_at = DateTime.Now.ToString("G"),
                    Status = true,
                },
                new TblProvider
                {
                    Id = Guid.Parse("a023c291-86f2-4945-aaa9-dbff1c2b6f25"),
                    Address = "Blvd.Timoteo Lozano #101-B Col.San Miguel",
                    BusinessName = "Simon Quimica",
                    ContactEmail = "ventassq@simonquimica.mx",
                    ContactName = "Erika Serrato",
                    ContactPhone = "4777705252",
                    Created_at = DateTime.Now.ToString("G"),
                    Status = true,
                }
            };
            modelBuilder.Entity<TblProvider>().HasData(providers);
        }
    }
}
