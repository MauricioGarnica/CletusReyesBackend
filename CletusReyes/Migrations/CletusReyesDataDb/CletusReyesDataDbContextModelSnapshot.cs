﻿// <auto-generated />
using System;
using CletusReyes.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CletusReyes.Migrations.CletusReyesDataDb
{
    [DbContext(typeof(CletusReyesDataDbContext))]
    partial class CletusReyesDataDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {

#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CletusReyes.Models.Domain_Model.Category.TblCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Created_at")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Updated_at")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserIdCreated")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserIdUpdated")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ffbf969b-36bb-47b3-a3ee-840523779c01"),
                            Created_at = "8/9/2023 3:02:11 AM",
                            Name = "GUANTES",
                            Status = true
                        },
                        new
                        {
                            Id = new Guid("3f98d5d2-f4be-4e0a-9b07-07f212973b0d"),
                            Created_at = "8/9/2023 3:02:11 AM",
                            Name = "PROTECCION",
                            Status = true
                        },
                        new
                        {
                            Id = new Guid("68598c64-99c6-487c-b0f8-c0044c137596"),
                            Created_at = "8/9/2023 3:02:11 AM",
                            Name = "COSTALES DE BOX",
                            Status = true
                        },
                        new
                        {
                            Id = new Guid("f63758e5-61e2-4bf3-925c-0cf137216fe6"),
                            Created_at = "8/9/2023 3:02:11 AM",
                            Name = "COACHING",
                            Status = true
                        },
                        new
                        {
                            Id = new Guid("35e3e543-5807-4805-890e-1d257fbeeee7"),
                            Created_at = "8/9/2023 3:02:11 AM",
                            Name = "ROPA Y CALZADO",
                            Status = true
                        });
                });

            modelBuilder.Entity("CletusReyes.Models.Domain_Model.Product.TblProduct", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Created_at")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileExtension")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("FileSizeInBytes")
                        .HasColumnType("bigint");

                    b.Property<int>("MaxValue")
                        .HasColumnType("int");

                    b.Property<int>("MinValue")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<Guid>("SizeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Updated_at")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserIdCreated")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserIdUpdated")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SizeId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("CletusReyes.Models.Domain_Model.Provider.TblProvider", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BusinessName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Created_at")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Updated_at")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserIdCreated")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserIdUpdated")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Providers");
                });

            modelBuilder.Entity("CletusReyes.Models.Domain_Model.Purchase_Order.TblPurchaseOrderDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<Guid>("PurchaseOrderHeaderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Quantity")
                        .HasColumnType("real");

                    b.Property<Guid>("RawMaterialId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PurchaseOrderHeaderId");

                    b.HasIndex("RawMaterialId");

                    b.ToTable("PurchaseOrderDetails");
                });

            modelBuilder.Entity("CletusReyes.Models.Domain_Model.Purchase_Order.TblPurchaseOrderHeader", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Created_at")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ProviderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PurchaseOrderStatusId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<float>("Total")
                        .HasColumnType("real");

                    b.Property<string>("Updated_at")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserIdCreated")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserIdUpdated")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProviderId");

                    b.HasIndex("PurchaseOrderStatusId");

                    b.ToTable("PurchaseOrderHeaders");
                });

            modelBuilder.Entity("CletusReyes.Models.Domain_Model.Purchase_Order.TblPurchaseOrderStatus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Created_at")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Updated_at")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserIdCreated")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserIdUpdated")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PurchaseOrderStatus");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6967f493-61ef-41af-b785-a9a8649e8767"),
                            Created_at = "8/9/2023 3:02:11 AM",
                            Name = "SOLICITADA",
                            Status = true
                        },
                        new
                        {
                            Id = new Guid("e2d2d115-764b-4264-a6a9-4a1f4d5f4dd4"),
                            Created_at = "8/9/2023 3:02:11 AM",
                            Name = "EN CAMINO",
                            Status = true
                        },
                        new
                        {
                            Id = new Guid("5e257c72-e959-4d0d-9894-1c8682515a3a"),
                            Created_at = "8/9/2023 3:02:11 AM",
                            Name = "ENTREGADA",
                            Status = true
                        },
                        new
                        {
                            Id = new Guid("196f0047-4231-4160-8d4e-124b8437dfac"),
                            Created_at = "8/9/2023 3:02:11 AM",
                            Name = "CANCELADA",
                            Status = true
                        });
                });

            modelBuilder.Entity("CletusReyes.Models.Domain_Model.Raw_Material.TblRawMaterial", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Created_at")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("MaxValue")
                        .HasColumnType("real");

                    b.Property<float>("MinValue")
                        .HasColumnType("real");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<Guid>("ProviderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Quantity")
                        .HasColumnType("real");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<Guid>("UnitMeasureId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Updated_at")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserIdCreated")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserIdUpdated")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProviderId");

                    b.HasIndex("UnitMeasureId");

                    b.ToTable("RawMaterials");
                });

            modelBuilder.Entity("CletusReyes.Models.Domain_Model.Recipe.TblRecipeDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Quantity")
                        .HasColumnType("real");

                    b.Property<Guid>("RawMaterialId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RecipeHeaderId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RawMaterialId");

                    b.HasIndex("RecipeHeaderId");

                    b.ToTable("RecipeDetails");
                });

            modelBuilder.Entity("CletusReyes.Models.Domain_Model.Recipe.TblRecipeHeader", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Created_at")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Updated_at")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserIdCreated")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserIdUpdated")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("RecipeHeaders");
                });

            modelBuilder.Entity("CletusReyes.Models.Domain_Model.Size.TblSize", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Created_at")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Updated_at")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserIdCreated")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserIdUpdated")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sizes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4847982e-f6e4-4d30-acfa-d4d3eb774025"),
                            Created_at = "8/9/2023 3:02:11 AM",
                            Size = "12oz",
                            Status = true
                        },
                        new
                        {
                            Id = new Guid("1afcad04-bae2-4edd-a936-7eea79380149"),
                            Created_at = "8/9/2023 3:02:11 AM",
                            Size = "14oz",
                            Status = true
                        },
                        new
                        {
                            Id = new Guid("24d0f481-814c-41b3-b0d8-4c875d89a95d"),
                            Created_at = "8/9/2023 3:02:11 AM",
                            Size = "16oz",
                            Status = true
                        });
                });

            modelBuilder.Entity("CletusReyes.Models.Domain_Model.Unit_Measure.TblUnitMeasure", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Created_at")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Updated_at")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserIdCreated")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserIdUpdated")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UnitMeasures");

                    b.HasData(
                        new
                        {
                            Id = new Guid("92743a31-78d1-4e8a-eb94-08db979fe8cb"),
                            Created_at = "8/9/2023 3:02:11 AM",
                            Name = "CM",
                            Status = true
                        },
                        new
                        {
                            Id = new Guid("7220fd18-43fe-4880-eb95-08db979fe8cb"),
                            Created_at = "8/9/2023 3:02:11 AM",
                            Name = "PZ",
                            Status = true
                        });
                });

            modelBuilder.Entity("CletusReyes.Models.Domain_Model.Product.TblProduct", b =>
                {
                    b.HasOne("CletusReyes.Models.Domain_Model.Category.TblCategory", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CletusReyes.Models.Domain_Model.Size.TblSize", "Size")
                        .WithMany()
                        .HasForeignKey("SizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Size");
                });

            modelBuilder.Entity("CletusReyes.Models.Domain_Model.Purchase_Order.TblPurchaseOrderDetail", b =>
                {
                    b.HasOne("CletusReyes.Models.Domain_Model.Purchase_Order.TblPurchaseOrderHeader", "PurchaseOrderHeader")
                        .WithMany("Details")
                        .HasForeignKey("PurchaseOrderHeaderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CletusReyes.Models.Domain_Model.Raw_Material.TblRawMaterial", "RawMaterial")
                        .WithMany()
                        .HasForeignKey("RawMaterialId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("PurchaseOrderHeader");

                    b.Navigation("RawMaterial");
                });

            modelBuilder.Entity("CletusReyes.Models.Domain_Model.Purchase_Order.TblPurchaseOrderHeader", b =>
                {
                    b.HasOne("CletusReyes.Models.Domain_Model.Provider.TblProvider", "Provider")
                        .WithMany()
                        .HasForeignKey("ProviderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CletusReyes.Models.Domain_Model.Purchase_Order.TblPurchaseOrderStatus", "PurchaseOrderStatus")
                        .WithMany()
                        .HasForeignKey("PurchaseOrderStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Provider");

                    b.Navigation("PurchaseOrderStatus");
                });

            modelBuilder.Entity("CletusReyes.Models.Domain_Model.Raw_Material.TblRawMaterial", b =>
                {
                    b.HasOne("CletusReyes.Models.Domain_Model.Provider.TblProvider", "Provider")
                        .WithMany()
                        .HasForeignKey("ProviderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CletusReyes.Models.Domain_Model.Unit_Measure.TblUnitMeasure", "UnitMeasure")
                        .WithMany()
                        .HasForeignKey("UnitMeasureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Provider");

                    b.Navigation("UnitMeasure");
                });

            modelBuilder.Entity("CletusReyes.Models.Domain_Model.Recipe.TblRecipeDetail", b =>
                {
                    b.HasOne("CletusReyes.Models.Domain_Model.Raw_Material.TblRawMaterial", "RawMaterial")
                        .WithMany()
                        .HasForeignKey("RawMaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CletusReyes.Models.Domain_Model.Recipe.TblRecipeHeader", "RecipeHeader")
                        .WithMany("Details")
                        .HasForeignKey("RecipeHeaderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RawMaterial");

                    b.Navigation("RecipeHeader");
                });

            modelBuilder.Entity("CletusReyes.Models.Domain_Model.Recipe.TblRecipeHeader", b =>
                {
                    b.HasOne("CletusReyes.Models.Domain_Model.Product.TblProduct", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("CletusReyes.Models.Domain_Model.Purchase_Order.TblPurchaseOrderHeader", b =>
                {
                    b.Navigation("Details");
                });

            modelBuilder.Entity("CletusReyes.Models.Domain_Model.Recipe.TblRecipeHeader", b =>
                {
                    b.Navigation("Details");
                });
#pragma warning restore 612, 618
        }
    }
}
