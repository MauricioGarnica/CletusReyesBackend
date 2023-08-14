﻿// <auto-generated />
using System;
using CletusReyes.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CletusReyes.Migrations
{
    [DbContext(typeof(CletusReyesDbContext))]
    [Migration("20230813224635_Add Person table")]
    partial class AddPersonstable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CletusReyes.Models.Domain_Model.Auth.TblRoles", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = "31f16eb0-8649-4015-9edd-b179b461a2dd",
                            ConcurrencyStamp = "31f16eb0-8649-4015-9edd-b179b461a2dd",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "f71926a4-5573-4a11-bb9c-875d856cd446",
                            ConcurrencyStamp = "f71926a4-5573-4a11-bb9c-875d856cd446",
                            Name = "Customer",
                            NormalizedName = "CUSTOMER"
                        });
                });

            modelBuilder.Entity("CletusReyes.Models.Domain_Model.Auth.TblUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CletusReyes.Models.Domain_Model.Auth.TblUserRoles", b =>
                {
                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("RoleId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles");
                });

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
                            Created_at = "8/13/2023 4:46:34 PM",
                            Name = "GUANTES",
                            Status = true
                        },
                        new
                        {
                            Id = new Guid("3f98d5d2-f4be-4e0a-9b07-07f212973b0d"),
                            Created_at = "8/13/2023 4:46:34 PM",
                            Name = "PROTECCION",
                            Status = true
                        },
                        new
                        {
                            Id = new Guid("68598c64-99c6-487c-b0f8-c0044c137596"),
                            Created_at = "8/13/2023 4:46:34 PM",
                            Name = "COSTALES DE BOX",
                            Status = true
                        },
                        new
                        {
                            Id = new Guid("f63758e5-61e2-4bf3-925c-0cf137216fe6"),
                            Created_at = "8/13/2023 4:46:34 PM",
                            Name = "COACHING",
                            Status = true
                        },
                        new
                        {
                            Id = new Guid("35e3e543-5807-4805-890e-1d257fbeeee7"),
                            Created_at = "8/13/2023 4:46:34 PM",
                            Name = "ROPA Y CALZADO",
                            Status = true
                        });
                });

            modelBuilder.Entity("CletusReyes.Models.Domain_Model.Person.TblPersons", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Birthday")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Persons");
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
                            Created_at = "8/13/2023 4:46:34 PM",
                            Name = "SOLICITADA",
                            Status = true
                        },
                        new
                        {
                            Id = new Guid("e2d2d115-764b-4264-a6a9-4a1f4d5f4dd4"),
                            Created_at = "8/13/2023 4:46:34 PM",
                            Name = "EN CAMINO",
                            Status = true
                        },
                        new
                        {
                            Id = new Guid("5e257c72-e959-4d0d-9894-1c8682515a3a"),
                            Created_at = "8/13/2023 4:46:34 PM",
                            Name = "ENTREGADA",
                            Status = true
                        },
                        new
                        {
                            Id = new Guid("196f0047-4231-4160-8d4e-124b8437dfac"),
                            Created_at = "8/13/2023 4:46:34 PM",
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

            modelBuilder.Entity("CletusReyes.Models.Domain_Model.Sale_Order.TblSaleOrderDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<Guid>("SaleOrderHeaderId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("SaleOrderHeaderId");

                    b.ToTable("SaleOrderDetails");
                });

            modelBuilder.Entity("CletusReyes.Models.Domain_Model.Sale_Order.TblSaleOrderHeader", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Created_at")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SaleOrderStatusId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<float>("Total")
                        .HasColumnType("real");

                    b.Property<string>("Updated_at")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserIdUpdated")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SaleOrderStatusId");

                    b.HasIndex("UserId");

                    b.ToTable("SaleOrderHeaders");
                });

            modelBuilder.Entity("CletusReyes.Models.Domain_Model.Sale_Order.TblSaleOrderStatus", b =>
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

                    b.ToTable("SaleOrderStatus");

                    b.HasData(
                        new
                        {
                            Id = new Guid("34e82473-b511-4b31-a94e-304130ee2ede"),
                            Created_at = "8/13/2023 4:46:34 PM",
                            Name = "PEDIDO",
                            Status = false
                        },
                        new
                        {
                            Id = new Guid("bf341b19-7e2e-492e-8aef-ebab9c33fe09"),
                            Created_at = "8/13/2023 4:46:34 PM",
                            Name = "ELABORANDO",
                            Status = false
                        },
                        new
                        {
                            Id = new Guid("aeb24d0e-7e62-4183-ace1-4401939ddce6"),
                            Created_at = "8/13/2023 4:46:34 PM",
                            Name = "EMPACANDO",
                            Status = false
                        },
                        new
                        {
                            Id = new Guid("25a4b068-bc82-4684-8bc5-5c4087d487e4"),
                            Created_at = "8/13/2023 4:46:34 PM",
                            Name = "ENVIANDO",
                            Status = false
                        },
                        new
                        {
                            Id = new Guid("d5f1c029-61cf-4273-a3d7-431c110e4f15"),
                            Created_at = "8/13/2023 4:46:34 PM",
                            Name = "ENTREGADO",
                            Status = false
                        },
                        new
                        {
                            Id = new Guid("cb22b5ba-8792-4675-88bb-e33beb098b7d"),
                            Created_at = "8/13/2023 4:46:34 PM",
                            Name = "CANCELADO",
                            Status = false
                        });
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
                            Created_at = "8/13/2023 4:46:34 PM",
                            Size = "12oz",
                            Status = true
                        },
                        new
                        {
                            Id = new Guid("1afcad04-bae2-4edd-a936-7eea79380149"),
                            Created_at = "8/13/2023 4:46:34 PM",
                            Size = "14oz",
                            Status = true
                        },
                        new
                        {
                            Id = new Guid("24d0f481-814c-41b3-b0d8-4c875d89a95d"),
                            Created_at = "8/13/2023 4:46:34 PM",
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

                    b.ToTable("UnitMeasures");

                    b.HasData(
                        new
                        {
                            Id = new Guid("92743a31-78d1-4e8a-eb94-08db979fe8cb"),
                            Created_at = "8/13/2023 4:46:34 PM",
                            Name = "CM",
                            Status = true
                        },
                        new
                        {
                            Id = new Guid("7220fd18-43fe-4880-eb95-08db979fe8cb"),
                            Created_at = "8/13/2023 4:46:34 PM",
                            Name = "PZ",
                            Status = true
                        });
                });

            modelBuilder.Entity("CletusReyes.Models.Domain_Model.Auth.TblUserRoles", b =>
                {
                    b.HasOne("CletusReyes.Models.Domain_Model.Auth.TblRoles", "Roles")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CletusReyes.Models.Domain_Model.Auth.TblUser", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Roles");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CletusReyes.Models.Domain_Model.Person.TblPersons", b =>
                {
                    b.HasOne("CletusReyes.Models.Domain_Model.Auth.TblUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
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
                        .OnDelete(DeleteBehavior.Cascade)
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

            modelBuilder.Entity("CletusReyes.Models.Domain_Model.Sale_Order.TblSaleOrderDetail", b =>
                {
                    b.HasOne("CletusReyes.Models.Domain_Model.Product.TblProduct", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CletusReyes.Models.Domain_Model.Sale_Order.TblSaleOrderHeader", "SaleOrderHeader")
                        .WithMany("Details")
                        .HasForeignKey("SaleOrderHeaderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("SaleOrderHeader");
                });

            modelBuilder.Entity("CletusReyes.Models.Domain_Model.Sale_Order.TblSaleOrderHeader", b =>
                {
                    b.HasOne("CletusReyes.Models.Domain_Model.Sale_Order.TblSaleOrderStatus", "SaleOrderStatus")
                        .WithMany()
                        .HasForeignKey("SaleOrderStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CletusReyes.Models.Domain_Model.Auth.TblUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SaleOrderStatus");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CletusReyes.Models.Domain_Model.Auth.TblRoles", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("CletusReyes.Models.Domain_Model.Auth.TblUser", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("CletusReyes.Models.Domain_Model.Purchase_Order.TblPurchaseOrderHeader", b =>
                {
                    b.Navigation("Details");
                });

            modelBuilder.Entity("CletusReyes.Models.Domain_Model.Recipe.TblRecipeHeader", b =>
                {
                    b.Navigation("Details");
                });

            modelBuilder.Entity("CletusReyes.Models.Domain_Model.Sale_Order.TblSaleOrderHeader", b =>
                {
                    b.Navigation("Details");
                });
#pragma warning restore 612, 618
        }
    }
}