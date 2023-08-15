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
                },
                new TblSize
                {
                    Id = Guid.Parse("98838e4b-fae5-4ae8-9cc3-05b794dc322e"),
                    Size = "CHICO",
                    Status = true,
                    Created_at = DateTime.Now.ToString("G")
                },
                new TblSize
                {
                    Id = Guid.Parse("83a96764-b2e4-4794-8f0a-69de7fe48143"),
                    Size = "MEDIANO",
                    Status = true,
                    Created_at = DateTime.Now.ToString("G")
                },
                new TblSize
                {
                    Id = Guid.Parse("515d8c75-f2f2-4473-8f82-405dedb5d613"),
                    Size = "GRANDE",
                    Status = true,
                    Created_at = DateTime.Now.ToString("G")
                },
                new TblSize
                {
                    Id = Guid.Parse("e38bff0e-b36d-4dd6-99b6-c23ee4e4a05a"),
                    Size = "NO APLICA",
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
                    Id = Guid.Parse("753ff726-1613-4e81-b936-39ecd53259d1"),
                    Address = "Boulevard Prolongación Tepeyac #1304 local 2 Col. Prados Verdes",
                    BusinessName = "Velcro Brand",
                    ContactEmail = "btlalolini@prodigy.net.mx",
                    ContactName = "Bruno Tlalolini",
                    ContactPhone = "4777747540",
                    Created_at = DateTime.Now.ToString("G"),
                    Status = true,
                },
                new TblProvider
                {
                    Id = Guid.Parse("4e097db4-5534-4d4b-b16c-4ce2550d9d32"),
                    Address = "Blvd.Antonio Madrazo #1216 Col.El Cortijo",
                    BusinessName = "Espumax",
                    ContactEmail = "espumax@gmail.com",
                    ContactName = "Ivan Sanchez",
                    ContactPhone = "4772335162",
                    Created_at = DateTime.Now.ToString("G"),
                    Status = true,
                },
                new TblProvider
                {
                    Id = Guid.Parse("2802ecd1-0b0f-46d0-8cd8-bb94be233e9e"),
                    Address = "Blvd. Hermenegildo Bustos #2217 col.Unidad Obrera Infonavit",
                    BusinessName = "Hilos Modiz",
                    ContactEmail = "modiz@gmail.com",
                    ContactName = "Araceli Gutierrez",
                    ContactPhone = "4777180275",
                    Created_at = DateTime.Now.ToString("G"),
                    Status = true,
                }
            };
            modelBuilder.Entity<TblProvider>().HasData(providers);

            //Seed data for raw materials
            var rawMaterials = new List<TblRawMaterial>
            {
                new TblRawMaterial
                {
                    Id = Guid.Parse("758a1a4e-c7f8-4058-a7c4-2602c0298b32"),
                    Created_at= DateTime.Now.ToString("G"),
                    MaxValue = 30000,
                    MinValue = 1500,
                    Name = "Piel de vaca color rojo",
                    Price = 350,
                    ProviderId = Guid.Parse("32a9172e-d7fd-4b44-83cc-48bfed5a80a1"),
                    Quantity = 15000,
                    Status = true,
                    UnitMeasureId = Guid.Parse("92743A31-78D1-4E8A-EB94-08DB979FE8CB"),
                    Description = ""
                },
                new TblRawMaterial
                {
                    Id = Guid.Parse("f11ccf0f-f8e9-4fda-8677-6992dd53a64b"),
                    Created_at= DateTime.Now.ToString("G"),
                    MaxValue = 20000,
                    MinValue = 1000,
                    Name = "Piel de vaca color negro",
                    Price = 325,
                    ProviderId = Guid.Parse("32a9172e-d7fd-4b44-83cc-48bfed5a80a1"),
                    Quantity = 7000,
                    Status = true,
                    UnitMeasureId = Guid.Parse("92743A31-78D1-4E8A-EB94-08DB979FE8CB"),
                    Description = ""
                },
                new TblRawMaterial
                {
                    Id = Guid.Parse("72294d1e-133a-4c69-9eb9-df383ad49819"),
                    Created_at= DateTime.Now.ToString("G"),
                    MaxValue = 25000,
                    MinValue = 2000,
                    Name = "Piel de vaca color dorado",
                    Price = 450,
                    ProviderId = Guid.Parse("32a9172e-d7fd-4b44-83cc-48bfed5a80a1"),
                    Quantity = 12000,
                    Status = true,
                    UnitMeasureId = Guid.Parse("92743A31-78D1-4E8A-EB94-08DB979FE8CB"),
                    Description = ""
                },
                new TblRawMaterial
                {
                    Id = Guid.Parse("5eb8fffa-c508-47a6-a662-0452993ea114"),
                    Created_at= DateTime.Now.ToString("G"),
                    MaxValue = 40000,
                    MinValue = 2000,
                    Name = "Piel de vaca color blanco",
                    Price = 375,
                    ProviderId = Guid.Parse("32a9172e-d7fd-4b44-83cc-48bfed5a80a1"),
                    Quantity = 20000,
                    Status = true,
                    UnitMeasureId = Guid.Parse("92743A31-78D1-4E8A-EB94-08DB979FE8CB"),
                    Description = ""
                },
                new TblRawMaterial
                {
                    Id = Guid.Parse("dff9d777-3531-4d9c-abcf-78f4fbff80fa"),
                    Created_at= DateTime.Now.ToString("G"),
                    MaxValue = 100000,
                    MinValue = 2000,
                    Name = "Piel sintetica color negro",
                    Price = 150,
                    ProviderId = Guid.Parse("66398fad-6c5a-4608-9a3e-dc9b58be6cf5"),
                    Quantity = 3500,
                    Status = true,
                    UnitMeasureId = Guid.Parse("92743A31-78D1-4E8A-EB94-08DB979FE8CB"),
                    Description = ""
                },
                new TblRawMaterial
                {
                    Id = Guid.Parse("d9fd1206-ccf1-44e6-979d-0d2dac1bccbd"),
                    Created_at= DateTime.Now.ToString("G"),
                    MaxValue = 10000,
                    MinValue = 200,
                    Name = "Piel sintetica color rojo",
                    Price = 125,
                    ProviderId = Guid.Parse("66398fad-6c5a-4608-9a3e-dc9b58be6cf5"),
                    Quantity = 3500,
                    Status = true,
                    UnitMeasureId = Guid.Parse("92743A31-78D1-4E8A-EB94-08DB979FE8CB"),
                    Description = ""
                },
                new TblRawMaterial
                {
                    Id = Guid.Parse("3bb6c3af-9fcc-462e-9f31-b7a20fd413d4"),
                    Created_at= DateTime.Now.ToString("G"),
                    MaxValue = 9000,
                    MinValue = 200,
                    Name = "Piel sintetica color blanco",
                    Price = 100,
                    ProviderId = Guid.Parse("66398fad-6c5a-4608-9a3e-dc9b58be6cf5"),
                    Quantity = 3500,
                    Status = true,
                    UnitMeasureId = Guid.Parse("92743A31-78D1-4E8A-EB94-08DB979FE8CB"),
                    Description = ""
                },
                new TblRawMaterial
                {
                    Id = Guid.Parse("d4736685-9730-40fd-a18e-5d7bdff280e2"),
                    Created_at= DateTime.Now.ToString("G"),
                    MaxValue = 11000,
                    MinValue = 500,
                    Name = "Piel sintetica color dorado",
                    Price = 200,
                    ProviderId = Guid.Parse("66398fad-6c5a-4608-9a3e-dc9b58be6cf5"),
                    Quantity = 3500,
                    Status = true,
                    UnitMeasureId = Guid.Parse("92743A31-78D1-4E8A-EB94-08DB979FE8CB"),
                    Description = ""
                },
                new TblRawMaterial
                {
                    Id = Guid.Parse("5ce0a50e-d43f-479c-a51d-5792c2405555"),
                    Created_at= DateTime.Now.ToString("G"),
                    MaxValue = 100,
                    MinValue = 5,
                    Name = "Goma espuma de 100*100cm",
                    Price = 350,
                    ProviderId = Guid.Parse("4e097db4-5534-4d4b-b16c-4ce2550d9d32"),
                    Quantity = 56,
                    Status = true,
                    UnitMeasureId = Guid.Parse("7220FD18-43FE-4880-EB95-08DB979FE8CB"),
                    Description = ""
                },
                new TblRawMaterial
                {
                    Id = Guid.Parse("250b5182-f96d-422f-9efd-0afd55221143"),
                    Created_at= DateTime.Now.ToString("G"),
                    MaxValue = 10000,
                    MinValue = 200,
                    Name = "Hilo negro",
                    Price = 100,
                    ProviderId = Guid.Parse("2802ecd1-0b0f-46d0-8cd8-bb94be233e9e"),
                    Quantity = 5000,
                    Status = true,
                    UnitMeasureId = Guid.Parse("92743A31-78D1-4E8A-EB94-08DB979FE8CB"),
                    Description = ""
                },
                new TblRawMaterial
                {
                    Id = Guid.Parse("0056c142-13f2-465d-824d-4299eaa3d45d"),
                    Created_at= DateTime.Now.ToString("G"),
                    MaxValue = 10000,
                    MinValue = 200,
                    Name = "Hilo blanco",
                    Price = 100,
                    ProviderId = Guid.Parse("2802ecd1-0b0f-46d0-8cd8-bb94be233e9e"),
                    Quantity = 5000,
                    Status = true,
                    UnitMeasureId = Guid.Parse("92743A31-78D1-4E8A-EB94-08DB979FE8CB"),
                    Description = ""
                },
                new TblRawMaterial
                {
                    Id = Guid.Parse("db9e6ef4-d516-448d-9c40-1ba7b7b83af2"),
                    Created_at= DateTime.Now.ToString("G"),
                    MaxValue = 10000,
                    MinValue = 200,
                    Name = "Hilo rojo",
                    Price = 100,
                    ProviderId = Guid.Parse("2802ecd1-0b0f-46d0-8cd8-bb94be233e9e"),
                    Quantity = 5000,
                    Status = true,
                    UnitMeasureId = Guid.Parse("92743A31-78D1-4E8A-EB94-08DB979FE8CB"),
                    Description = ""
                },
                new TblRawMaterial
                {
                    Id = Guid.Parse("bc94f5cf-8b87-4860-8fb4-a5794f06833d"),
                    Created_at= DateTime.Now.ToString("G"),
                    MaxValue = 10000,
                    MinValue = 200,
                    Name = "Hilo dorado",
                    Price = 100,
                    ProviderId = Guid.Parse("2802ecd1-0b0f-46d0-8cd8-bb94be233e9e"),
                    Quantity = 5000,
                    Status = true,
                    UnitMeasureId = Guid.Parse("92743A31-78D1-4E8A-EB94-08DB979FE8CB"),
                    Description = ""
                },
                new TblRawMaterial
                {
                    Id = Guid.Parse("bb156abe-638f-4243-b338-5f7ed26d2f47"),
                    Created_at= DateTime.Now.ToString("G"),
                    MaxValue = 20000,
                    MinValue = 500,
                    Name = "Velcro negro",
                    Price = 250,
                    ProviderId = Guid.Parse("753ff726-1613-4e81-b936-39ecd53259d1"),
                    Quantity = 5000,
                    Status = true,
                    UnitMeasureId = Guid.Parse("92743A31-78D1-4E8A-EB94-08DB979FE8CB"),
                    Description = "Rollos de 100cm con 10cm de espesor"
                },
                new TblRawMaterial
                {
                    Id = Guid.Parse("279b5ed0-e9e0-4e2c-88fd-176ad5b8847a"),
                    Created_at= DateTime.Now.ToString("G"),
                    MaxValue = 20000,
                    MinValue = 500,
                    Name = "Velcro rojo",
                    Price = 235,
                    ProviderId = Guid.Parse("753ff726-1613-4e81-b936-39ecd53259d1"),
                    Quantity = 5000,
                    Status = true,
                    UnitMeasureId = Guid.Parse("92743A31-78D1-4E8A-EB94-08DB979FE8CB"),
                    Description = "Rollos de 100cm con 10cm de espesor"
                },
                new TblRawMaterial
                {
                    Id = Guid.Parse("83e4c615-648c-4405-aed6-bbd084ea105f"),
                    Created_at= DateTime.Now.ToString("G"),
                    MaxValue = 20000,
                    MinValue = 500,
                    Name = "Velcro blanco",
                    Price = 235,
                    ProviderId = Guid.Parse("753ff726-1613-4e81-b936-39ecd53259d1"),
                    Quantity = 5000,
                    Status = true,
                    UnitMeasureId = Guid.Parse("92743A31-78D1-4E8A-EB94-08DB979FE8CB"),
                    Description = "Rollos de 100cm con 10cm de espesor"
                },
            };
            modelBuilder.Entity<TblRawMaterial>().HasData(rawMaterials);

            //Seed data for products
            var products = new List<TblProduct>
            {
                new TblProduct
                {
                    Id = Guid.Parse("05ca4c98-738a-47d0-ad57-0837f79042d6"),
                    CategoryId = Guid.Parse("ffbf969b-36bb-47b3-a3ee-840523779c01"),
                    Created_at = DateTime.Now.ToString("G"),
                    Description = "",
                    FileDescription = "",
                    FileExtension = ".jpg",
                    FileName = "Guantesrojos16oz",
                    FilePath = "https://localhost:7088/Images/Guantesrojos16oz.jpg",
                    FileSizeInBytes = 0,
                    MaxValue = 15,
                    MinValue = 3,
                    Name = "Guantes rojos 16oz",
                    Price = 1250,
                    Quantity = 10,
                    SizeId = Guid.Parse("24d0f481-814c-41b3-b0d8-4c875d89a95d"),
                    Status = true
                },
                new TblProduct
                {
                    Id = Guid.Parse("6cbd63b4-f0c6-4cc8-99ca-6263e150e474"),
                    CategoryId = Guid.Parse("ffbf969b-36bb-47b3-a3ee-840523779c01"),
                    Created_at = DateTime.Now.ToString("G"),
                    Description = "",
                    FileDescription = "",
                    FileExtension = ".jpg",
                    FileName = "Guantesnegros16oz",
                    FilePath = "https://localhost:7088/Images/Guantesnegros16oz.jpg",
                    FileSizeInBytes = 0,
                    MaxValue = 20,
                    MinValue = 5,
                    Name = "Guantes negros 16oz",
                    Price = 1150,
                    Quantity = 10,
                    SizeId = Guid.Parse("24d0f481-814c-41b3-b0d8-4c875d89a95d"),
                    Status = true
                },
                new TblProduct
                {
                    Id = Guid.Parse("45715fa2-fdb2-4ced-8c21-76d71f374037"),
                    CategoryId = Guid.Parse("ffbf969b-36bb-47b3-a3ee-840523779c01"),
                    Created_at = DateTime.Now.ToString("G"),
                    Description = "",
                    FileDescription = "",
                    FileExtension = ".png",
                    FileName = "Guantesrojos14oz",
                    FilePath = "https://localhost:7088/Images/Guantesrojos14oz.png",
                    FileSizeInBytes = 0,
                    MaxValue = 12,
                    MinValue = 2,
                    Name = "Guantes rojos 14oz",
                    Price = 1300,
                    Quantity = 8,
                    SizeId = Guid.Parse("1AFCAD04-BAE2-4EDD-A936-7EEA79380149"),
                    Status = true
                },
                new TblProduct
                {
                    Id = Guid.Parse("b028a88c-80ea-4b62-8a45-4059d5dedf01"),
                    CategoryId = Guid.Parse("ffbf969b-36bb-47b3-a3ee-840523779c01"),
                    Created_at = DateTime.Now.ToString("G"),
                    Description = "",
                    FileDescription = "",
                    FileExtension = ".jpg",
                    FileName = "Guantesnegros14oz",
                    FilePath = "https://localhost:7088/Images/Guantesnegros14oz.jpg",
                    FileSizeInBytes = 0,
                    MaxValue = 11,
                    MinValue = 3,
                    Name = "Guantes negros 14oz",
                    Price = 1250,
                    Quantity = 8,
                    SizeId = Guid.Parse("1AFCAD04-BAE2-4EDD-A936-7EEA79380149"),
                    Status = true
                },
                new TblProduct
                {
                    Id = Guid.Parse("9591d94e-2a82-49c5-ad1f-2dd1b7fa6837"),
                    CategoryId = Guid.Parse("ffbf969b-36bb-47b3-a3ee-840523779c01"),
                    Created_at = DateTime.Now.ToString("G"),
                    Description = "",
                    FileDescription = "",
                    FileExtension = ".jpeg",
                    FileName = "Guantesrojos12oz",
                    FilePath = "https://localhost:7088/Images/Guantesrojos12oz.jpeg",
                    FileSizeInBytes = 0,
                    MaxValue = 10,
                    MinValue = 2,
                    Name = "Guantes rojos 12oz",
                    Price = 1400,
                    Quantity = 6,
                    SizeId = Guid.Parse("4847982E-F6E4-4D30-ACFA-D4D3EB774025"),
                    Status = true
                },
                new TblProduct
                {
                    Id = Guid.Parse("d13a1ae6-4dc0-4bb3-bf1d-184ac3d18885"),
                    CategoryId = Guid.Parse("ffbf969b-36bb-47b3-a3ee-840523779c01"),
                    Created_at = DateTime.Now.ToString("G"),
                    Description = "",
                    FileDescription = "",
                    FileExtension = ".jpeg",
                    FileName = "Guantesnegros12oz",
                    FilePath = "https://localhost:7088/Images/Guantesnegros12oz.jpeg",
                    FileSizeInBytes = 0,
                    MaxValue = 13,
                    MinValue = 4,
                    Name = "Guantes negros 12oz",
                    Price = 1000,
                    Quantity = 6,
                    SizeId = Guid.Parse("4847982E-F6E4-4D30-ACFA-D4D3EB774025"),
                    Status = true
                }
            };
            modelBuilder.Entity<TblProduct>().HasData(products);
        }
    }
}
