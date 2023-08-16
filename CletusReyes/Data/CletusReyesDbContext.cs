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
                    Id = Guid.Parse("515d8c75-f2f2-4473-8f82-405dedb5d613"),
                    Size = "ADULTO",
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
                    Id = Guid.Parse("fc000f09-4a69-4937-b7b0-80215b37de73"),
                    CategoryId = Guid.Parse("ffbf969b-36bb-47b3-a3ee-840523779c01"),
                    Created_at = DateTime.Now.ToString("G"),
                    Description = "",
                    FileDescription = "",
                    FileExtension = ".jpeg",
                    FileName = "Guantesblancos16oz",
                    FilePath = "https://localhost:7088/Images/Guantesblancos16oz.jpeg",
                    FileSizeInBytes = 0,
                    MaxValue = 20,
                    MinValue = 5,
                    Name = "Guantes blancos 16oz",
                    Price = 1150,
                    Quantity = 10,
                    SizeId = Guid.Parse("24d0f481-814c-41b3-b0d8-4c875d89a95d"),
                    Status = true
                },
                new TblProduct
                {
                    Id = Guid.Parse("b9aa5ff6-9eac-4853-aaef-3e9ac0e77329"),
                    CategoryId = Guid.Parse("ffbf969b-36bb-47b3-a3ee-840523779c01"),
                    Created_at = DateTime.Now.ToString("G"),
                    Description = "",
                    FileDescription = "",
                    FileExtension = ".jpg",
                    FileName = "Guantesdorados16oz",
                    FilePath = "https://localhost:7088/Images/Guantesdorados16oz.jpg",
                    FileSizeInBytes = 0,
                    MaxValue = 15,
                    MinValue = 1,
                    Name = "Guantes dorados 16oz",
                    Price = 1600,
                    Quantity = 7,
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
                    Id = Guid.Parse("6aa0de18-fa8b-4070-a4dc-79cec6e1e700"),
                    CategoryId = Guid.Parse("ffbf969b-36bb-47b3-a3ee-840523779c01"),
                    Created_at = DateTime.Now.ToString("G"),
                    Description = "",
                    FileDescription = "",
                    FileExtension = ".jpg",
                    FileName = "Guantesblancos14oz",
                    FilePath = "https://localhost:7088/Images/Guantesblancos14oz.jpg",
                    FileSizeInBytes = 0,
                    MaxValue = 11,
                    MinValue = 3,
                    Name = "Guantes blancos 14oz",
                    Price = 1250,
                    Quantity = 8,
                    SizeId = Guid.Parse("1AFCAD04-BAE2-4EDD-A936-7EEA79380149"),
                    Status = true
                },
                new TblProduct
                {
                    Id = Guid.Parse("1432c9e0-c549-4e9d-8586-a8cabc81fbae"),
                    CategoryId = Guid.Parse("ffbf969b-36bb-47b3-a3ee-840523779c01"),
                    Created_at = DateTime.Now.ToString("G"),
                    Description = "",
                    FileDescription = "",
                    FileExtension = ".jpg",
                    FileName = "Guantesdorados14oz",
                    FilePath = "https://localhost:7088/Images/Guantesdorados14oz.jpg",
                    FileSizeInBytes = 0,
                    MaxValue = 10,
                    MinValue = 1,
                    Name = "Guantes dorados 14oz",
                    Price = 1550,
                    Quantity = 6,
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
                },
                new TblProduct
                {
                    Id = Guid.Parse("9d1801c2-52f1-425d-bf45-67eedcfc4179"),
                    CategoryId = Guid.Parse("ffbf969b-36bb-47b3-a3ee-840523779c01"),
                    Created_at = DateTime.Now.ToString("G"),
                    Description = "",
                    FileDescription = "",
                    FileExtension = ".jpg",
                    FileName = "Guantesblancos12oz",
                    FilePath = "https://localhost:7088/Images/Guantesblancos12oz.jpeg",
                    FileSizeInBytes = 0,
                    MaxValue = 10,
                    MinValue = 2,
                    Name = "Guantes blancos 12oz",
                    Price = 1400,
                    Quantity = 6,
                    SizeId = Guid.Parse("4847982E-F6E4-4D30-ACFA-D4D3EB774025"),
                    Status = true
                },
                new TblProduct
                {
                    Id = Guid.Parse("4175f4ae-4750-4ceb-bfa8-7ff83b0a1d7e"),
                    CategoryId = Guid.Parse("ffbf969b-36bb-47b3-a3ee-840523779c01"),
                    Created_at = DateTime.Now.ToString("G"),
                    Description = "",
                    FileDescription = "",
                    FileExtension = ".jpg",
                    FileName = "Guantesdorados12oz",
                    FilePath = "https://localhost:7088/Images/Guantesdorados12oz.jpeg",
                    FileSizeInBytes = 0,
                    MaxValue = 8,
                    MinValue = 1,
                    Name = "Guantes dorados 12oz",
                    Price = 1500,
                    Quantity = 1,
                    SizeId = Guid.Parse("4847982E-F6E4-4D30-ACFA-D4D3EB774025"),
                    Status = true
                },
                new TblProduct
                {
                    Id = Guid.Parse("e1095653-b2fd-46c1-8f54-3c4d30a9401a"),
                    CategoryId = Guid.Parse("3F98D5D2-F4BE-4E0A-9B07-07F212973B0D"),
                    Created_at = DateTime.Now.ToString("G"),
                    Description = "",
                    FileDescription = "",
                    FileExtension = ".jpg",
                    FileName = "Caretarojaadulto",
                    FilePath = "https://localhost:7088/Images/Caretarojaadulto.jpg",
                    FileSizeInBytes = 0,
                    MaxValue = 25,
                    MinValue = 5,
                    Name = "Careta roja adulto",
                    Price = 1000,
                    Quantity = 10,
                    SizeId = Guid.Parse("515d8c75-f2f2-4473-8f82-405dedb5d613"),
                    Status = true
                },
                new TblProduct
                {
                    Id = Guid.Parse("6528d6ce-e99c-4a78-99f7-20201d8c8aa3"),
                    CategoryId = Guid.Parse("3F98D5D2-F4BE-4E0A-9B07-07F212973B0D"),
                    Created_at = DateTime.Now.ToString("G"),
                    Description = "",
                    FileDescription = "",
                    FileExtension = ".jpg",
                    FileName = "Caretanegraadulto",
                    FilePath = "https://localhost:7088/Images/Caretanegraadulto.jpg",
                    FileSizeInBytes = 0,
                    MaxValue = 25,
                    MinValue = 5,
                    Name = "Careta negra adulto",
                    Price = 1000,
                    Quantity = 10,
                    SizeId = Guid.Parse("515d8c75-f2f2-4473-8f82-405dedb5d613"),
                    Status = true
                },
                new TblProduct
                {
                    Id = Guid.Parse("fca25f2b-ec65-4e45-9c4b-9c2351ccebed"),
                    CategoryId = Guid.Parse("3F98D5D2-F4BE-4E0A-9B07-07F212973B0D"),
                    Created_at = DateTime.Now.ToString("G"),
                    Description = "",
                    FileDescription = "",
                    FileExtension = ".jpg",
                    FileName = "Caretablancaadulto",
                    FilePath = "https://localhost:7088/Images/Caretablancaadulto.jpg",
                    FileSizeInBytes = 0,
                    MaxValue = 25,
                    MinValue = 5,
                    Name = "Careta blanca adulto",
                    Price = 1000,
                    Quantity = 10,
                    SizeId = Guid.Parse("515d8c75-f2f2-4473-8f82-405dedb5d613"),
                    Status = true
                },
                new TblProduct
                {
                    Id = Guid.Parse("2ae73b97-e8a8-4de2-9ad7-e0fbfc583677"),
                    CategoryId = Guid.Parse("3F98D5D2-F4BE-4E0A-9B07-07F212973B0D"),
                    Created_at = DateTime.Now.ToString("G"),
                    Description = "",
                    FileDescription = "",
                    FileExtension = ".jpg",
                    FileName = "Caretarojachica",
                    FilePath = "https://localhost:7088/Images/Caretarojachica.jpg",
                    FileSizeInBytes = 0,
                    MaxValue = 25,
                    MinValue = 5,
                    Name = "Careta roja chica",
                    Price = 1000,
                    Quantity = 10,
                    SizeId = Guid.Parse("98838e4b-fae5-4ae8-9cc3-05b794dc322e"),
                    Status = true
                },
                new TblProduct
                {
                    Id = Guid.Parse("94c66e3f-9138-4e41-8bf0-8a31c2241262"),
                    CategoryId = Guid.Parse("3f98d5d2-f4be-4e0a-9b07-07f212973b0d"),
                    Created_at = DateTime.Now.ToString("G"),
                    Description = "",
                    FileDescription = "",
                    FileExtension = ".jpg",
                    FileName = "Caretanegrachica",
                    FilePath = "https://localhost:7088/Images/Caretanegrachica.jpg",
                    FileSizeInBytes = 0,
                    MaxValue = 25,
                    MinValue = 5,
                    Name = "Careta negra chica",
                    Price = 1000,
                    Quantity = 10,
                    SizeId = Guid.Parse("98838e4b-fae5-4ae8-9cc3-05b794dc322e"),
                    Status = true
                },
                new TblProduct
                {
                    Id = Guid.Parse("17ed600e-4634-474d-b58d-a20085f0fa05"),
                    CategoryId = Guid.Parse("3f98d5d2-f4be-4e0a-9b07-07f212973b0d"),
                    Created_at = DateTime.Now.ToString("G"),
                    Description = "",
                    FileDescription = "",
                    FileExtension = ".jpg",
                    FileName = "Caretablancachica",
                    FilePath = "https://localhost:7088/Images/Caretablancachica.jpg",
                    FileSizeInBytes = 0,
                    MaxValue = 25,
                    MinValue = 5,
                    Name = "Careta blanca chica",
                    Price = 1000,
                    Quantity = 10,
                    SizeId = Guid.Parse("98838e4b-fae5-4ae8-9cc3-05b794dc322e"),
                    Status = true
                }
            };
            modelBuilder.Entity<TblProduct>().HasData(products);

            //Seed data for users
            var users = new List<TblUser>
            {
                new TblUser
                {
                    AccessFailedCount = 0,
                    ConcurrencyStamp = "d0b4c159-28a4-4549-8997-dfd3daf80f01",
                    Email = "brandonv@gmail.com",
                    EmailConfirmed = false,
                    Id = "0fbcb272-5086-4b30-a6c9-66d72a9bde37",
                    LockoutEnabled = true,
                    LockoutEnd = null,
                    NormalizedEmail = "BRANDONV@GMAIL.COM",
                    NormalizedUserName = "BR",
                    PasswordHash = "AQAAAAIAAYagAAAAEN7In5GO6ZXZMuEVck1ROa10p35O99ff9LiOWQTyQ7udEMYHBsR3ja6fjokzlfCCDA==",
                    PhoneNumber = null,
                    PhoneNumberConfirmed = false,
                    SecurityStamp = "CUAI6OTACIJT7M5PZNWCHLP22PLTZAPC",
                    TwoFactorEnabled = false,
                    UserName = "br",
                },
                new TblUser
                {
                    AccessFailedCount = 0,
                    ConcurrencyStamp = "c8c0877f-b150-4dc9-9ecc-e8482540506d",
                    Email = "userAdmin@gmail.com",
                    EmailConfirmed = false,
                    Id = "215dc03c-ef26-46a5-8031-7dec9f87928e",
                    LockoutEnabled = true,
                    LockoutEnd = null,
                    NormalizedEmail = "USERADMIN@GMAIL.COM",
                    NormalizedUserName = "US",
                    PasswordHash = "AQAAAAIAAYagAAAAEPTpuqL+e6zLtCCnJZc6q15xVOwdplQ0HIOX/vGQaPEOEsyNxPgTdf3NM6tZOlcG8A==",
                    PhoneNumber = null,
                    PhoneNumberConfirmed = false,
                    SecurityStamp = "KXCSIA5K65MWJRCFUK5VYWSXY5VFHPLA",
                    TwoFactorEnabled = false,
                    UserName = "us",
                },
                new TblUser
                {
                    AccessFailedCount = 0,
                    ConcurrencyStamp = "15d949bc-9f4f-4d71-9cb8-67389f590824",
                    Email = "hassela@gmail.com",
                    EmailConfirmed = false,
                    Id = "22380616-12fd-4e2e-b86e-58c11a76ec52",
                    LockoutEnabled = true,
                    LockoutEnd = null,
                    NormalizedEmail = "HASSELA@GMAIL.COM",
                    NormalizedUserName = "HA",
                    PasswordHash = "AQAAAAIAAYagAAAAELQKXjBfM/ccxR6zNAnWsmDi868hrY3GOpShW40PvJ5riTWfoZtzKCXjV3rvPWd5Wg==",
                    PhoneNumber = null,
                    PhoneNumberConfirmed = false,
                    SecurityStamp = "5N7VD76YPQD4FW6YUUBBCAHAHRL5AFKL",
                    TwoFactorEnabled = false,
                    UserName = "ha",
                },
                new TblUser
                {
                    AccessFailedCount = 0,
                    ConcurrencyStamp = "3d705dfb-9118-4ff8-b0d7-e8a36406bd1e",
                    Email = "davids@gmail.com",
                    EmailConfirmed = false,
                    Id = "342d70c0-a00c-43e3-a069-36d5ed2005b5",
                    LockoutEnabled = true,
                    LockoutEnd = null,
                    NormalizedEmail = "DAVIDS@GMAIL.COM",
                    NormalizedUserName = "DA",
                    PasswordHash = "AQAAAAIAAYagAAAAEPWa3z1JivXSVIsH4/f9xiPATWxo/Mn4gUPN8UT/Rr3lP7GqFujw5GaApai3q1xSCQ==",
                    PhoneNumber = null,
                    PhoneNumberConfirmed = false,
                    SecurityStamp = "TMTKWNY7REES6S2GR3LMS56FO5PPSDAC",
                    TwoFactorEnabled = false,
                    UserName = "da",
                },
                new TblUser
                {
                    AccessFailedCount = 0,
                    ConcurrencyStamp = "3bd9f4ea-ffed-456c-a230-7d36262c03c4",
                    Email = "paulav@gmail.com",
                    EmailConfirmed = false,
                    Id = "36e4d06a-831d-4f23-b491-537f20825375",
                    LockoutEnabled = true,
                    LockoutEnd = null,
                    NormalizedEmail = "PAULAV@GMAIL.COM",
                    NormalizedUserName = "PA",
                    PasswordHash = "AQAAAAIAAYagAAAAEHcWTHI+/fLKYWfl9puPAkgPEDMEo7Fyk9fTvn7LTX/239SFT7dPq+YJRU2bKXykWg==",
                    PhoneNumber = null,
                    PhoneNumberConfirmed = false,
                    SecurityStamp = "J7E6JPE4I5YPWSLOER3D47YSRZ4WIVUJ",
                    TwoFactorEnabled = false,
                    UserName = "pa",
                },
                new TblUser
                {
                    AccessFailedCount = 0,
                    ConcurrencyStamp = "3cde4d24-d01f-4e2a-828f-14a06e6bd1e2",
                    Email = "armandot@gmail.com",
                    EmailConfirmed = false,
                    Id = "3b79afd6-5b42-4685-af13-c47b20fc4b38",
                    LockoutEnabled = true,
                    LockoutEnd = null,
                    NormalizedEmail = "ARMANDOT@GMAIL.COM",
                    NormalizedUserName = "AR",
                    PasswordHash = "AQAAAAIAAYagAAAAEOlBn+tvSEUnH3UHWOKqKdljUc9vGaKbjBKJl/c9OZWbxIobXk1Cvpkb01k65bqOgg==",
                    PhoneNumber = null,
                    PhoneNumberConfirmed = false,
                    SecurityStamp = "DNFYPMJOGCLJUJXJH5LXL7WAQFL6ZOGS",
                    TwoFactorEnabled = false,
                    UserName = "ar",
                },
                new TblUser
                {
                    AccessFailedCount = 0,
                    ConcurrencyStamp = "aad98d39-1e7c-42fa-9a98-e89a8c868494",
                    Email = "ivano@gmail.com",
                    EmailConfirmed = false,
                    Id = "4523059a-0da7-412c-8e2b-d35300943dde",
                    LockoutEnabled = true,
                    LockoutEnd = null,
                    NormalizedEmail = "IVANO@GMAIL.COM",
                    NormalizedUserName = "IV",
                    PasswordHash = "AQAAAAIAAYagAAAAEDr3sLGMjjMRKJPwnCmh8cIt2qCcAEvJIcp7rJ0ZQ3rnihFhS54r+LVF3+OsN91GUw==",
                    PhoneNumber = null,
                    PhoneNumberConfirmed = false,
                    SecurityStamp = "HPT5IN4VHJ4LX5DPB2ZBX6VOKUIMLBSV",
                    TwoFactorEnabled = false,
                    UserName = "iv",
                },
                new TblUser
                {
                    AccessFailedCount = 0,
                    ConcurrencyStamp = "f069e819-076a-454e-8ea6-415bfd1dc57e",
                    Email = "nestorp@gmail.com",
                    EmailConfirmed = false,
                    Id = "4a8bf52a-fdba-4ebf-8996-48f3536df4e0",
                    LockoutEnabled = true,
                    LockoutEnd = null,
                    NormalizedEmail = "NESTORP@GMAIL.COM",
                    NormalizedUserName = "NE",
                    PasswordHash = "AQAAAAIAAYagAAAAEEqILrxhTzKyoFped6EGnaW8yhDh5a7/DOKpjL1MeoiIKirauJfw/WQMR3zWhztEKQ==",
                    PhoneNumber = null,
                    PhoneNumberConfirmed = false,
                    SecurityStamp = "7X33NX64SQEGL2VIKKWXC2MIESWZD5CP",
                    TwoFactorEnabled = false,
                    UserName = "ne",
                },
                new TblUser
                {
                    AccessFailedCount = 0,
                    ConcurrencyStamp = "f8e90e5e-c074-4441-83c2-bd6da62adb7f",
                    Email = "yairt@gmail.com",
                    EmailConfirmed = false,
                    Id = "4d9c2616-e560-4039-8208-64ce82943c6d",
                    LockoutEnabled = true,
                    LockoutEnd = null,
                    NormalizedEmail = "YAIRT@GMAIL.COM",
                    NormalizedUserName = "YA",
                    PasswordHash = "AQAAAAIAAYagAAAAEDIxLoKzxmjR5784C/y0PTHrjiCMZxzgE7kPGSGLszy1ojibmrSpDgmwqbUdNZRtJg==",
                    PhoneNumber = null,
                    PhoneNumberConfirmed = false,
                    SecurityStamp = "L567LCB6OXMLMH3GNQAIRRVA2PZME3J2",
                    TwoFactorEnabled = false,
                    UserName = "ya",
                },
                new TblUser
                {
                    AccessFailedCount = 0,
                    ConcurrencyStamp = "fd86759e-a728-4301-bb4c-7a4bd0d76336",
                    Email = "melissas@gmail.com",
                    EmailConfirmed = false,
                    Id = "58243206-3daf-48e2-ad79-9505d858a741",
                    LockoutEnabled = true,
                    LockoutEnd = null,
                    NormalizedEmail = "MELISSAS@GMAIL.COM",
                    NormalizedUserName = "ME",
                    PasswordHash = "AQAAAAIAAYagAAAAEBi3bmCMzBOpBwvB3H4WRpPYkTTF4EAymmC5lvC0tDtcR3T0wSxP2V02PMjqVX0eXA==",
                    PhoneNumber = null,
                    PhoneNumberConfirmed = false,
                    SecurityStamp = "KCMCB2Y5FBFRLSXVRVOR57G4L2TWH34U",
                    TwoFactorEnabled = false,
                    UserName = "me",
                },
                new TblUser
                {
                    AccessFailedCount = 0,
                    ConcurrencyStamp = "d0ea11d1-ccc0-463a-88f1-5fb5261438e8",
                    Email = "angelt@gmail.com",
                    EmailConfirmed = false,
                    Id = "5fa062eb-77ff-4a87-a3a5-2e67baf727fe",
                    LockoutEnabled = true,
                    LockoutEnd = null,
                    NormalizedEmail = "ANGELT@GMAIL.COM",
                    NormalizedUserName = "AN",
                    PasswordHash = "AQAAAAIAAYagAAAAEJOJnprX10E6HPvCGvqUNkQST5KMHVFKpUSYAIRa4dN4e4QlcSDpcLDZLsLBlzb7Vw==",
                    PhoneNumber = null,
                    PhoneNumberConfirmed = false,
                    SecurityStamp = "STNJRBEA3GU6MYQBRQOEFLGKD3HNPBVU",
                    TwoFactorEnabled = false,
                    UserName = "an",
                },
                new TblUser
                {
                    AccessFailedCount = 0,
                    ConcurrencyStamp = "57a840e4-b8c1-4576-bd4a-1340fe4654cb",
                    Email = "eduardog@gmail.com",
                    EmailConfirmed = false,
                    Id = "781e5335-f900-42c6-bdf4-fac0317f6e93",
                    LockoutEnabled = true,
                    LockoutEnd = null,
                    NormalizedEmail = "EDUARDOG@GMAIL.COM",
                    NormalizedUserName = "ED",
                    PasswordHash = "AQAAAAIAAYagAAAAEHoBR3pPzzaia+dxqUhTUidaWVMWN6pg2WlpWtvx0qDqbrvQ3y/bRcgMgdTGkHkYnA==",
                    PhoneNumber = null,
                    PhoneNumberConfirmed = false,
                    SecurityStamp = "GUAH3AHJMPXADJBAZ3G5DMHLHNOXFKYP",
                    TwoFactorEnabled = false,
                    UserName = "ed",
                },
                new TblUser
                {
                    AccessFailedCount = 0,
                    ConcurrencyStamp = "d5c22f09-206b-4881-9e6c-4e05c29f218a",
                    Email = "robertoa@gmail.com",
                    EmailConfirmed = false,
                    Id = "78838dfd-5967-48f5-b021-d40ba2534420",
                    LockoutEnabled = true,
                    LockoutEnd = null,
                    NormalizedEmail = "ROBERTOA@GMAIL.COM",
                    NormalizedUserName = "RO",
                    PasswordHash = "AQAAAAIAAYagAAAAEDBNBqM/0WjbRLwzIKlBDrQ+wD0955oTp9piGthVheqGGYQkMQwkHjU4BnCwlMuQ7Q==",
                    PhoneNumber = null,
                    PhoneNumberConfirmed = false,
                    SecurityStamp = "SRBSEEET4CXMTP7DG5FBPU4HZN57ZNQA",
                    TwoFactorEnabled = false,
                    UserName = "ro",
                },
                new TblUser
                {
                    AccessFailedCount = 0,
                    ConcurrencyStamp = "690ead78-7316-4d85-8b49-8fb6c2e0d447",
                    Email = "erikal@gmail.com",
                    EmailConfirmed = false,
                    Id = "79fc643e-6a9d-49b6-8d88-e34b30db128e",
                    LockoutEnabled = true,
                    LockoutEnd = null,
                    NormalizedEmail = "ERIKAL@GMAIL.COM",
                    NormalizedUserName = "ER",
                    PasswordHash = "AQAAAAIAAYagAAAAEGUesq+GO7rZCWGG5uaMDtFzWwYA6Mc7BfHT3Kqw7fTOKvjBsNCOCftdG7gy17+YBQ==",
                    PhoneNumber = null,
                    PhoneNumberConfirmed = false,
                    SecurityStamp = "EIIAZJXNUPKW4U7PSVDWMH2R2PSWFLCZ",
                    TwoFactorEnabled = false,
                    UserName = "er",
                },
                new TblUser
                {
                    AccessFailedCount = 0,
                    ConcurrencyStamp = "33427e9b-439d-474b-af9d-53aeb7afc432",
                    Email = "carlosr@gmail.com",
                    EmailConfirmed = false,
                    Id = "8aa459a0-1d85-4d57-9fae-ce5f2a14f724",
                    LockoutEnabled = true,
                    LockoutEnd = null,
                    NormalizedEmail = "CARLOSR@GMAIL.COM",
                    NormalizedUserName = "CA",
                    PasswordHash = "AQAAAAIAAYagAAAAEJ2GQLjlQaeDA+4RvBLt22a9WwY9sPJdHTNnJ4Bjn2gLUTrzdbmKNSdMuNOWMuJm9w==",
                    PhoneNumber = null,
                    PhoneNumberConfirmed = false,
                    SecurityStamp = "SW5K5NEPVYPUZ7YMSB2WOSNIJDVCV7B6",
                    TwoFactorEnabled = false,
                    UserName = "ca",
                },
                new TblUser
                {
                    AccessFailedCount = 0,
                    ConcurrencyStamp = "63f2498c-efb6-48b0-8806-f31ba1272bde",
                    Email = "admin@gmail.com",
                    EmailConfirmed = false,
                    Id = "97ae5e15-8186-4973-b30f-db14f044ecd1",
                    LockoutEnabled = true,
                    LockoutEnd = null,
                    NormalizedEmail = "ADMIN@GMAIL.COM",
                    NormalizedUserName = "AD",
                    PasswordHash = "AQAAAAIAAYagAAAAECbxfh2Xstsmcg8XS7lNIXyQLHKqSHIgCoiRYBU3HyKkD0ToJJHjB8QEDxC8ApKLZg==",
                    PhoneNumber = null,
                    PhoneNumberConfirmed = false,
                    SecurityStamp = "WKXI4J3UH7JDYV3Z2UAZH42FJRI5XEK5",
                    TwoFactorEnabled = false,
                    UserName = "ad",
                },
                new TblUser
                {
                    AccessFailedCount = 0,
                    ConcurrencyStamp = "8db9eaa9-55bf-4a9f-9361-ac0784611b13",
                    Email = "juanh@gmail.com",
                    EmailConfirmed = false,
                    Id = "9af86b7a-507e-4926-869e-19d4b8308a90",
                    LockoutEnabled = true,
                    LockoutEnd = null,
                    NormalizedEmail = "JUANH@GMAIL.COM",
                    NormalizedUserName = "JU",
                    PasswordHash = "AQAAAAIAAYagAAAAEK/dZ2sdJFLerp0Pszdtmy9W0BrVZ5FSMdBNzOSBODRNtszmiEfnztsMy0Wf4gvO1g==",
                    PhoneNumber = null,
                    PhoneNumberConfirmed = false,
                    SecurityStamp = "XPLMFC4J7JCJFFKOVE3WJ4EA2UUCDIPW",
                    TwoFactorEnabled = false,
                    UserName = "ju",
                },
                new TblUser
                {
                    AccessFailedCount = 0,
                    ConcurrencyStamp = "9af6c859-7285-4afa-8cb6-b2f12da9bb89",
                    Email = "mauriciog@gmail.com",
                    EmailConfirmed = false,
                    Id = "c5eb9a3e-9e53-4571-9722-8ef7f5b9adde",
                    LockoutEnabled = true,
                    LockoutEnd = null,
                    NormalizedEmail = "MAURICIOG@GMAIL.COM",
                    NormalizedUserName = "MA",
                    PasswordHash = "AQAAAAIAAYagAAAAEH3O0cXtfEesxc9NEdMz7sPPrscptLG53zF7pwcCHuR70yxANJ0Cnc0GZ27hInT6lA==",
                    PhoneNumber = null,
                    PhoneNumberConfirmed = false,
                    SecurityStamp = "VFB3GMIGNMX4FN3BZI4QBROWBNUASHHD",
                    TwoFactorEnabled = false,
                    UserName = "ma",
                },
                new TblUser
                {
                    AccessFailedCount = 0,
                    ConcurrencyStamp = "3fb2a60b-5186-407e-9590-927803f1bc6e",
                    Email = "alanf@gmail.com",
                    EmailConfirmed = false,
                    Id = "d8216863-0000-4786-9d35-2211760bbe49",
                    LockoutEnabled = true,
                    LockoutEnd = null,
                    NormalizedEmail = "ALANF@GMAIL.COM",
                    NormalizedUserName = "AL",
                    PasswordHash = "AQAAAAIAAYagAAAAEOg67tu4zWwFXczSRahki5kueIITKKiaO5GiNPPe4EMSaFp/QkvnLtSR14ZEwUC3Lg==",
                    PhoneNumber = null,
                    PhoneNumberConfirmed = false,
                    SecurityStamp = "FVCI754PQ7O7HEXBLA4UFJFJCLG7WGXX",
                    TwoFactorEnabled = false,
                    UserName = "al",
                },
                new TblUser
                {
                    AccessFailedCount = 0,
                    ConcurrencyStamp = "dded809a-8d66-44d8-b495-cc80d82bf964",
                    Email = "adrianh@gmail.com",
                    EmailConfirmed = false,
                    Id = "e68d4af8-8674-4949-8be4-0667112cc4a8",
                    LockoutEnabled = true,
                    LockoutEnd = null,
                    NormalizedEmail = "ADRIANH@GMAIL.COM",
                    NormalizedUserName = "ADR",
                    PasswordHash = "AQAAAAIAAYagAAAAEFEwvrirTZu6Y6pHxH6NNnfxp3w9KlD0TI6N49YsJNYCnKb5rT1ajtDL9mKoa0BD8g==",
                    PhoneNumber = null,
                    PhoneNumberConfirmed = false,
                    SecurityStamp = "QMFHQDBFU7YL2QIF756DTJ4XHK4C3R74",
                    TwoFactorEnabled = false,
                    UserName = "adr",
                },
            };
            modelBuilder.Entity<TblUser>().HasData(users);

            var userRoles = new List<TblUserRoles>
            {
                new TblUserRoles
                {
                    UserId = "0fbcb272-5086-4b30-a6c9-66d72a9bde37",
                    RoleId = "f71926a4-5573-4a11-bb9c-875d856cd446"
                },
                new TblUserRoles
                {
                    UserId = "215dc03c-ef26-46a5-8031-7dec9f87928e",
                    RoleId = "31f16eb0-8649-4015-9edd-b179b461a2dd"
                },
                new TblUserRoles
                {
                    UserId = "22380616-12fd-4e2e-b86e-58c11a76ec52",
                    RoleId = "f71926a4-5573-4a11-bb9c-875d856cd446"
                },
                new TblUserRoles
                {
                    UserId = "342d70c0-a00c-43e3-a069-36d5ed2005b5",
                    RoleId = "f71926a4-5573-4a11-bb9c-875d856cd446"
                },
                new TblUserRoles
                {
                    UserId = "36e4d06a-831d-4f23-b491-537f20825375",
                    RoleId = "f71926a4-5573-4a11-bb9c-875d856cd446"
                },
                new TblUserRoles
                {
                    UserId = "3b79afd6-5b42-4685-af13-c47b20fc4b38",
                    RoleId = "f71926a4-5573-4a11-bb9c-875d856cd446"
                },
                new TblUserRoles
                {
                    UserId = "4523059a-0da7-412c-8e2b-d35300943dde",
                    RoleId = "f71926a4-5573-4a11-bb9c-875d856cd446"
                },
                new TblUserRoles
                {
                    UserId = "4a8bf52a-fdba-4ebf-8996-48f3536df4e0",
                    RoleId = "f71926a4-5573-4a11-bb9c-875d856cd446"
                },
                new TblUserRoles
                {
                    UserId = "4d9c2616-e560-4039-8208-64ce82943c6d",
                    RoleId = "f71926a4-5573-4a11-bb9c-875d856cd446"
                },
                new TblUserRoles
                {
                    UserId = "58243206-3daf-48e2-ad79-9505d858a741",
                    RoleId = "f71926a4-5573-4a11-bb9c-875d856cd446"
                },
                new TblUserRoles
                {
                    UserId = "5fa062eb-77ff-4a87-a3a5-2e67baf727fe",
                    RoleId = "f71926a4-5573-4a11-bb9c-875d856cd446"
                },
                new TblUserRoles
                {
                    UserId = "781e5335-f900-42c6-bdf4-fac0317f6e93",
                    RoleId = "f71926a4-5573-4a11-bb9c-875d856cd446"
                },
                new TblUserRoles
                {
                    UserId = "78838dfd-5967-48f5-b021-d40ba2534420",
                    RoleId = "f71926a4-5573-4a11-bb9c-875d856cd446"
                },
                new TblUserRoles
                {
                    UserId = "79fc643e-6a9d-49b6-8d88-e34b30db128e",
                    RoleId = "f71926a4-5573-4a11-bb9c-875d856cd446"
                },
                new TblUserRoles
                {
                    UserId = "8aa459a0-1d85-4d57-9fae-ce5f2a14f724",
                    RoleId = "f71926a4-5573-4a11-bb9c-875d856cd446"
                },
                new TblUserRoles
                {
                    UserId = "97ae5e15-8186-4973-b30f-db14f044ecd1",
                    RoleId = "f71926a4-5573-4a11-bb9c-875d856cd446"
                },
                new TblUserRoles
                {
                    UserId = "9af86b7a-507e-4926-869e-19d4b8308a90",
                    RoleId = "f71926a4-5573-4a11-bb9c-875d856cd446"
                },
                new TblUserRoles
                {
                    UserId = "c5eb9a3e-9e53-4571-9722-8ef7f5b9adde",
                    RoleId = "f71926a4-5573-4a11-bb9c-875d856cd446"
                },
                new TblUserRoles
                {
                    UserId = "d8216863-0000-4786-9d35-2211760bbe49",
                    RoleId = "f71926a4-5573-4a11-bb9c-875d856cd446"
                },
                new TblUserRoles
                {
                    UserId = "e68d4af8-8674-4949-8be4-0667112cc4a8",
                    RoleId = "f71926a4-5573-4a11-bb9c-875d856cd446"
                },
            };
            modelBuilder.Entity<TblUserRoles>().HasData(userRoles);
        }
    }
}
