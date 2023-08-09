using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CletusReyes.Migrations.CletusReyesDataDb
{
    /// <inheritdoc />
    public partial class AddPurchaseOrderTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("35e3e543-5807-4805-890e-1d257fbeeee7"),
                columns: new[] { "Created_at", "Name" },
                values: new object[] { "8/9/2023 3:02:11 AM", "ROPA Y CALZADO" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3f98d5d2-f4be-4e0a-9b07-07f212973b0d"),
                columns: new[] { "Created_at", "Name" },
                values: new object[] { "8/9/2023 3:02:11 AM", "PROTECCION" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("68598c64-99c6-487c-b0f8-c0044c137596"),
                columns: new[] { "Created_at", "Name" },
                values: new object[] { "8/9/2023 3:02:11 AM", "COSTALES DE BOX" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f63758e5-61e2-4bf3-925c-0cf137216fe6"),
                columns: new[] { "Created_at", "Name" },
                values: new object[] { "8/9/2023 3:02:11 AM", "COACHING" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ffbf969b-36bb-47b3-a3ee-840523779c01"),
                columns: new[] { "Created_at", "Name" },
                values: new object[] { "8/9/2023 3:02:11 AM", "GUANTES" });

            migrationBuilder.InsertData(
                table: "PurchaseOrderStatus",
                columns: new[] { "Id", "Created_at", "Description", "Name", "Status", "Updated_at", "UserIdCreated", "UserIdUpdated" },
                values: new object[,]
                {
                    { new Guid("196f0047-4231-4160-8d4e-124b8437dfac"), "8/9/2023 3:02:11 AM", null, "CANCELADA", true, null, null, null },
                    { new Guid("5e257c72-e959-4d0d-9894-1c8682515a3a"), "8/9/2023 3:02:11 AM", null, "ENTREGADA", true, null, null, null },
                    { new Guid("6967f493-61ef-41af-b785-a9a8649e8767"), "8/9/2023 3:02:11 AM", null, "SOLICITADA", true, null, null, null },
                    { new Guid("e2d2d115-764b-4264-a6a9-4a1f4d5f4dd4"), "8/9/2023 3:02:11 AM", null, "EN CAMINO", true, null, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("1afcad04-bae2-4edd-a936-7eea79380149"),
                column: "Created_at",
                value: "8/9/2023 3:02:11 AM");

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("24d0f481-814c-41b3-b0d8-4c875d89a95d"),
                column: "Created_at",
                value: "8/9/2023 3:02:11 AM");

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("4847982e-f6e4-4d30-acfa-d4d3eb774025"),
                column: "Created_at",
                value: "8/9/2023 3:02:11 AM");

            migrationBuilder.UpdateData(
                table: "UnitMeasures",
                keyColumn: "Id",
                keyValue: new Guid("7220fd18-43fe-4880-eb95-08db979fe8cb"),
                column: "Created_at",
                value: "8/9/2023 3:02:11 AM");

            migrationBuilder.UpdateData(
                table: "UnitMeasures",
                keyColumn: "Id",
                keyValue: new Guid("92743a31-78d1-4e8a-eb94-08db979fe8cb"),
                column: "Created_at",
                value: "8/9/2023 3:02:11 AM");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PurchaseOrderDetails");

            migrationBuilder.DropTable(
                name: "PurchaseOrderHeaders");

            migrationBuilder.DropTable(
                name: "PurchaseOrderStatus");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("35e3e543-5807-4805-890e-1d257fbeeee7"),
                columns: new[] { "Created_at", "Name" },
                values: new object[] { null, "Ropa y calzado" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3f98d5d2-f4be-4e0a-9b07-07f212973b0d"),
                columns: new[] { "Created_at", "Name" },
                values: new object[] { null, "Proteccion" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("68598c64-99c6-487c-b0f8-c0044c137596"),
                columns: new[] { "Created_at", "Name" },
                values: new object[] { null, "Costales de box" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f63758e5-61e2-4bf3-925c-0cf137216fe6"),
                columns: new[] { "Created_at", "Name" },
                values: new object[] { null, "Coaching" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ffbf969b-36bb-47b3-a3ee-840523779c01"),
                columns: new[] { "Created_at", "Name" },
                values: new object[] { null, "Guantes" });

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("1afcad04-bae2-4edd-a936-7eea79380149"),
                column: "Created_at",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("24d0f481-814c-41b3-b0d8-4c875d89a95d"),
                column: "Created_at",
                value: null);

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("4847982e-f6e4-4d30-acfa-d4d3eb774025"),
                column: "Created_at",
                value: null);

            migrationBuilder.UpdateData(
                table: "UnitMeasures",
                keyColumn: "Id",
                keyValue: new Guid("7220fd18-43fe-4880-eb95-08db979fe8cb"),
                column: "Created_at",
                value: null);

            migrationBuilder.UpdateData(
                table: "UnitMeasures",
                keyColumn: "Id",
                keyValue: new Guid("92743a31-78d1-4e8a-eb94-08db979fe8cb"),
                column: "Created_at",
                value: null);
        }
    }
}
