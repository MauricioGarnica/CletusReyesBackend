using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CletusReyes.Migrations
{
    /// <inheritdoc />
    public partial class Addultimatemigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Created_at = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserIdCreated = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Updated_at = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserIdUpdated = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Providers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BusinessName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Created_at = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserIdCreated = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Updated_at = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserIdUpdated = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Providers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrderStatus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Created_at = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserIdCreated = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Updated_at = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserIdUpdated = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrderStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SaleOrderStatus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Created_at = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserIdCreated = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Updated_at = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserIdUpdated = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleOrderStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Created_at = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserIdCreated = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Updated_at = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserIdUpdated = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnitMeasures",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Created_at = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserIdCreated = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Updated_at = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserIdUpdated = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitMeasures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrderHeaders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProviderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PurchaseOrderStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Total = table.Column<float>(type: "real", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Created_at = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserIdCreated = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Updated_at = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserIdUpdated = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrderHeaders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchaseOrderHeaders_Providers_ProviderId",
                        column: x => x.ProviderId,
                        principalTable: "Providers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PurchaseOrderHeaders_PurchaseOrderStatus_PurchaseOrderStatusId",
                        column: x => x.PurchaseOrderStatusId,
                        principalTable: "PurchaseOrderStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    MinValue = table.Column<int>(type: "int", nullable: false),
                    MaxValue = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SizeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileExtension = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileSizeInBytes = table.Column<long>(type: "bigint", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Created_at = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserIdCreated = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Updated_at = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserIdUpdated = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Sizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Sizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RawMaterials",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ProviderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UnitMeasureId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MinValue = table.Column<float>(type: "real", nullable: false),
                    MaxValue = table.Column<float>(type: "real", nullable: false),
                    Quantity = table.Column<float>(type: "real", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Created_at = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserIdCreated = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Updated_at = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserIdUpdated = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RawMaterials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RawMaterials_Providers_ProviderId",
                        column: x => x.ProviderId,
                        principalTable: "Providers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RawMaterials_UnitMeasures_UnitMeasureId",
                        column: x => x.UnitMeasureId,
                        principalTable: "UnitMeasures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SaleOrderHeaders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Total = table.Column<float>(type: "real", nullable: false),
                    SaleOrderStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Created_at = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Updated_at = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserIdUpdated = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleOrderHeaders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SaleOrderHeaders_SaleOrderStatus_SaleOrderStatusId",
                        column: x => x.SaleOrderStatusId,
                        principalTable: "SaleOrderStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SaleOrderHeaders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.RoleId, x.UserId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RecipeHeaders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Created_at = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserIdCreated = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Updated_at = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserIdUpdated = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeHeaders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RecipeHeaders_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrderDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RawMaterialId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PurchaseOrderHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Quantity = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchaseOrderDetails_PurchaseOrderHeaders_PurchaseOrderHeaderId",
                        column: x => x.PurchaseOrderHeaderId,
                        principalTable: "PurchaseOrderHeaders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PurchaseOrderDetails_RawMaterials_RawMaterialId",
                        column: x => x.RawMaterialId,
                        principalTable: "RawMaterials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "SaleOrderDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SaleOrderHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleOrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SaleOrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SaleOrderDetails_SaleOrderHeaders_SaleOrderHeaderId",
                        column: x => x.SaleOrderHeaderId,
                        principalTable: "SaleOrderHeaders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RecipeDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RecipeHeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RawMaterialId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RecipeDetails_RawMaterials_RawMaterialId",
                        column: x => x.RawMaterialId,
                        principalTable: "RawMaterials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecipeDetails_RecipeHeaders_RecipeHeaderId",
                        column: x => x.RecipeHeaderId,
                        principalTable: "RecipeHeaders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Created_at", "Description", "Name", "Status", "Updated_at", "UserIdCreated", "UserIdUpdated" },
                values: new object[,]
                {
                    { new Guid("35e3e543-5807-4805-890e-1d257fbeeee7"), "8/12/2023 1:30:58 AM", null, "ROPA Y CALZADO", true, null, null, null },
                    { new Guid("3f98d5d2-f4be-4e0a-9b07-07f212973b0d"), "8/12/2023 1:30:58 AM", null, "PROTECCION", true, null, null, null },
                    { new Guid("68598c64-99c6-487c-b0f8-c0044c137596"), "8/12/2023 1:30:58 AM", null, "COSTALES DE BOX", true, null, null, null },
                    { new Guid("f63758e5-61e2-4bf3-925c-0cf137216fe6"), "8/12/2023 1:30:58 AM", null, "COACHING", true, null, null, null },
                    { new Guid("ffbf969b-36bb-47b3-a3ee-840523779c01"), "8/12/2023 1:30:58 AM", null, "GUANTES", true, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "PurchaseOrderStatus",
                columns: new[] { "Id", "Created_at", "Description", "Name", "Status", "Updated_at", "UserIdCreated", "UserIdUpdated" },
                values: new object[,]
                {
                    { new Guid("196f0047-4231-4160-8d4e-124b8437dfac"), "8/12/2023 1:30:58 AM", null, "CANCELADA", true, null, null, null },
                    { new Guid("5e257c72-e959-4d0d-9894-1c8682515a3a"), "8/12/2023 1:30:58 AM", null, "ENTREGADA", true, null, null, null },
                    { new Guid("6967f493-61ef-41af-b785-a9a8649e8767"), "8/12/2023 1:30:58 AM", null, "SOLICITADA", true, null, null, null },
                    { new Guid("e2d2d115-764b-4264-a6a9-4a1f4d5f4dd4"), "8/12/2023 1:30:58 AM", null, "EN CAMINO", true, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "31f16eb0-8649-4015-9edd-b179b461a2dd", "31f16eb0-8649-4015-9edd-b179b461a2dd", "Admin", "ADMIN" },
                    { "f71926a4-5573-4a11-bb9c-875d856cd446", "f71926a4-5573-4a11-bb9c-875d856cd446", "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "SaleOrderStatus",
                columns: new[] { "Id", "Created_at", "Description", "Name", "Status", "Updated_at", "UserIdCreated", "UserIdUpdated" },
                values: new object[,]
                {
                    { new Guid("25a4b068-bc82-4684-8bc5-5c4087d487e4"), "8/12/2023 1:30:58 AM", null, "ENVIANDO", false, null, null, null },
                    { new Guid("34e82473-b511-4b31-a94e-304130ee2ede"), "8/12/2023 1:30:58 AM", null, "PEDIDO", false, null, null, null },
                    { new Guid("aeb24d0e-7e62-4183-ace1-4401939ddce6"), "8/12/2023 1:30:58 AM", null, "EMPACANDO", false, null, null, null },
                    { new Guid("bf341b19-7e2e-492e-8aef-ebab9c33fe09"), "8/12/2023 1:30:58 AM", null, "ELABORANDO", false, null, null, null },
                    { new Guid("cb22b5ba-8792-4675-88bb-e33beb098b7d"), "8/12/2023 1:30:58 AM", null, "CANCELADO", false, null, null, null },
                    { new Guid("d5f1c029-61cf-4273-a3d7-431c110e4f15"), "8/12/2023 1:30:58 AM", null, "ENTREGADO", false, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "Created_at", "Description", "Size", "Status", "Updated_at", "UserIdCreated", "UserIdUpdated" },
                values: new object[,]
                {
                    { new Guid("1afcad04-bae2-4edd-a936-7eea79380149"), "8/12/2023 1:30:58 AM", null, "14oz", true, null, null, null },
                    { new Guid("24d0f481-814c-41b3-b0d8-4c875d89a95d"), "8/12/2023 1:30:58 AM", null, "16oz", true, null, null, null },
                    { new Guid("4847982e-f6e4-4d30-acfa-d4d3eb774025"), "8/12/2023 1:30:58 AM", null, "12oz", true, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "UnitMeasures",
                columns: new[] { "Id", "Created_at", "Description", "Name", "Status", "Updated_at", "UserIdCreated", "UserIdUpdated" },
                values: new object[,]
                {
                    { new Guid("7220fd18-43fe-4880-eb95-08db979fe8cb"), "8/12/2023 1:30:58 AM", null, "PZ", true, null, null, null },
                    { new Guid("92743a31-78d1-4e8a-eb94-08db979fe8cb"), "8/12/2023 1:30:58 AM", null, "CM", true, null, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SizeId",
                table: "Products",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderDetails_PurchaseOrderHeaderId",
                table: "PurchaseOrderDetails",
                column: "PurchaseOrderHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderDetails_RawMaterialId",
                table: "PurchaseOrderDetails",
                column: "RawMaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderHeaders_ProviderId",
                table: "PurchaseOrderHeaders",
                column: "ProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderHeaders_PurchaseOrderStatusId",
                table: "PurchaseOrderHeaders",
                column: "PurchaseOrderStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_RawMaterials_ProviderId",
                table: "RawMaterials",
                column: "ProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_RawMaterials_UnitMeasureId",
                table: "RawMaterials",
                column: "UnitMeasureId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeDetails_RawMaterialId",
                table: "RecipeDetails",
                column: "RawMaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeDetails_RecipeHeaderId",
                table: "RecipeDetails",
                column: "RecipeHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeHeaders_ProductId",
                table: "RecipeHeaders",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleOrderDetails_ProductId",
                table: "SaleOrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleOrderDetails_SaleOrderHeaderId",
                table: "SaleOrderDetails",
                column: "SaleOrderHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleOrderHeaders_SaleOrderStatusId",
                table: "SaleOrderHeaders",
                column: "SaleOrderStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleOrderHeaders_UserId",
                table: "SaleOrderHeaders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PurchaseOrderDetails");

            migrationBuilder.DropTable(
                name: "RecipeDetails");

            migrationBuilder.DropTable(
                name: "SaleOrderDetails");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "PurchaseOrderHeaders");

            migrationBuilder.DropTable(
                name: "RawMaterials");

            migrationBuilder.DropTable(
                name: "RecipeHeaders");

            migrationBuilder.DropTable(
                name: "SaleOrderHeaders");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "PurchaseOrderStatus");

            migrationBuilder.DropTable(
                name: "Providers");

            migrationBuilder.DropTable(
                name: "UnitMeasures");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "SaleOrderStatus");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Sizes");
        }
    }
}
