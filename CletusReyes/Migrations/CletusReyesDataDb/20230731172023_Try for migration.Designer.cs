﻿// <auto-generated />
using System;
using CletusReyes.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CletusReyes.Migrations.CletusReyesDataDb
{
    [DbContext(typeof(CletusReyesDataDbContext))]
    [Migration("20230731172023_Try for migration")]
    partial class Tryformigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CletusReyes.Models.Domain_Model.Size.TblSize", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Updated_at")
                        .HasColumnType("datetime2");

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
                            Size = "12oz",
                            Status = true
                        },
                        new
                        {
                            Id = new Guid("1afcad04-bae2-4edd-a936-7eea79380149"),
                            Size = "14oz",
                            Status = true
                        },
                        new
                        {
                            Id = new Guid("24d0f481-814c-41b3-b0d8-4c875d89a95d"),
                            Size = "16oz",
                            Status = true
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
