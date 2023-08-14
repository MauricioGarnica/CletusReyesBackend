using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CletusReyes.Migrations
{
    /// <inheritdoc />
    public partial class AddPersontable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birthday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Persons_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("35e3e543-5807-4805-890e-1d257fbeeee7"),
                column: "Created_at",
                value: "8/13/2023 4:46:34 PM");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3f98d5d2-f4be-4e0a-9b07-07f212973b0d"),
                column: "Created_at",
                value: "8/13/2023 4:46:34 PM");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("68598c64-99c6-487c-b0f8-c0044c137596"),
                column: "Created_at",
                value: "8/13/2023 4:46:34 PM");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f63758e5-61e2-4bf3-925c-0cf137216fe6"),
                column: "Created_at",
                value: "8/13/2023 4:46:34 PM");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ffbf969b-36bb-47b3-a3ee-840523779c01"),
                column: "Created_at",
                value: "8/13/2023 4:46:34 PM");

            migrationBuilder.UpdateData(
                table: "PurchaseOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("196f0047-4231-4160-8d4e-124b8437dfac"),
                column: "Created_at",
                value: "8/13/2023 4:46:34 PM");

            migrationBuilder.UpdateData(
                table: "PurchaseOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("5e257c72-e959-4d0d-9894-1c8682515a3a"),
                column: "Created_at",
                value: "8/13/2023 4:46:34 PM");

            migrationBuilder.UpdateData(
                table: "PurchaseOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("6967f493-61ef-41af-b785-a9a8649e8767"),
                column: "Created_at",
                value: "8/13/2023 4:46:34 PM");

            migrationBuilder.UpdateData(
                table: "PurchaseOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("e2d2d115-764b-4264-a6a9-4a1f4d5f4dd4"),
                column: "Created_at",
                value: "8/13/2023 4:46:34 PM");

            migrationBuilder.UpdateData(
                table: "SaleOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("25a4b068-bc82-4684-8bc5-5c4087d487e4"),
                column: "Created_at",
                value: "8/13/2023 4:46:34 PM");

            migrationBuilder.UpdateData(
                table: "SaleOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("34e82473-b511-4b31-a94e-304130ee2ede"),
                column: "Created_at",
                value: "8/13/2023 4:46:34 PM");

            migrationBuilder.UpdateData(
                table: "SaleOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("aeb24d0e-7e62-4183-ace1-4401939ddce6"),
                column: "Created_at",
                value: "8/13/2023 4:46:34 PM");

            migrationBuilder.UpdateData(
                table: "SaleOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("bf341b19-7e2e-492e-8aef-ebab9c33fe09"),
                column: "Created_at",
                value: "8/13/2023 4:46:34 PM");

            migrationBuilder.UpdateData(
                table: "SaleOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("cb22b5ba-8792-4675-88bb-e33beb098b7d"),
                column: "Created_at",
                value: "8/13/2023 4:46:34 PM");

            migrationBuilder.UpdateData(
                table: "SaleOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("d5f1c029-61cf-4273-a3d7-431c110e4f15"),
                column: "Created_at",
                value: "8/13/2023 4:46:34 PM");

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("1afcad04-bae2-4edd-a936-7eea79380149"),
                column: "Created_at",
                value: "8/13/2023 4:46:34 PM");

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("24d0f481-814c-41b3-b0d8-4c875d89a95d"),
                column: "Created_at",
                value: "8/13/2023 4:46:34 PM");

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("4847982e-f6e4-4d30-acfa-d4d3eb774025"),
                column: "Created_at",
                value: "8/13/2023 4:46:34 PM");

            migrationBuilder.UpdateData(
                table: "UnitMeasures",
                keyColumn: "Id",
                keyValue: new Guid("7220fd18-43fe-4880-eb95-08db979fe8cb"),
                column: "Created_at",
                value: "8/13/2023 4:46:34 PM");

            migrationBuilder.UpdateData(
                table: "UnitMeasures",
                keyColumn: "Id",
                keyValue: new Guid("92743a31-78d1-4e8a-eb94-08db979fe8cb"),
                column: "Created_at",
                value: "8/13/2023 4:46:34 PM");

            migrationBuilder.CreateIndex(
                name: "IX_Person_UserId",
                table: "Person",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("35e3e543-5807-4805-890e-1d257fbeeee7"),
                column: "Created_at",
                value: "8/12/2023 1:30:58 AM");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3f98d5d2-f4be-4e0a-9b07-07f212973b0d"),
                column: "Created_at",
                value: "8/12/2023 1:30:58 AM");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("68598c64-99c6-487c-b0f8-c0044c137596"),
                column: "Created_at",
                value: "8/12/2023 1:30:58 AM");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f63758e5-61e2-4bf3-925c-0cf137216fe6"),
                column: "Created_at",
                value: "8/12/2023 1:30:58 AM");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ffbf969b-36bb-47b3-a3ee-840523779c01"),
                column: "Created_at",
                value: "8/12/2023 1:30:58 AM");

            migrationBuilder.UpdateData(
                table: "PurchaseOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("196f0047-4231-4160-8d4e-124b8437dfac"),
                column: "Created_at",
                value: "8/12/2023 1:30:58 AM");

            migrationBuilder.UpdateData(
                table: "PurchaseOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("5e257c72-e959-4d0d-9894-1c8682515a3a"),
                column: "Created_at",
                value: "8/12/2023 1:30:58 AM");

            migrationBuilder.UpdateData(
                table: "PurchaseOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("6967f493-61ef-41af-b785-a9a8649e8767"),
                column: "Created_at",
                value: "8/12/2023 1:30:58 AM");

            migrationBuilder.UpdateData(
                table: "PurchaseOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("e2d2d115-764b-4264-a6a9-4a1f4d5f4dd4"),
                column: "Created_at",
                value: "8/12/2023 1:30:58 AM");

            migrationBuilder.UpdateData(
                table: "SaleOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("25a4b068-bc82-4684-8bc5-5c4087d487e4"),
                column: "Created_at",
                value: "8/12/2023 1:30:58 AM");

            migrationBuilder.UpdateData(
                table: "SaleOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("34e82473-b511-4b31-a94e-304130ee2ede"),
                column: "Created_at",
                value: "8/12/2023 1:30:58 AM");

            migrationBuilder.UpdateData(
                table: "SaleOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("aeb24d0e-7e62-4183-ace1-4401939ddce6"),
                column: "Created_at",
                value: "8/12/2023 1:30:58 AM");

            migrationBuilder.UpdateData(
                table: "SaleOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("bf341b19-7e2e-492e-8aef-ebab9c33fe09"),
                column: "Created_at",
                value: "8/12/2023 1:30:58 AM");

            migrationBuilder.UpdateData(
                table: "SaleOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("cb22b5ba-8792-4675-88bb-e33beb098b7d"),
                column: "Created_at",
                value: "8/12/2023 1:30:58 AM");

            migrationBuilder.UpdateData(
                table: "SaleOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("d5f1c029-61cf-4273-a3d7-431c110e4f15"),
                column: "Created_at",
                value: "8/12/2023 1:30:58 AM");

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("1afcad04-bae2-4edd-a936-7eea79380149"),
                column: "Created_at",
                value: "8/12/2023 1:30:58 AM");

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("24d0f481-814c-41b3-b0d8-4c875d89a95d"),
                column: "Created_at",
                value: "8/12/2023 1:30:58 AM");

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("4847982e-f6e4-4d30-acfa-d4d3eb774025"),
                column: "Created_at",
                value: "8/12/2023 1:30:58 AM");

            migrationBuilder.UpdateData(
                table: "UnitMeasures",
                keyColumn: "Id",
                keyValue: new Guid("7220fd18-43fe-4880-eb95-08db979fe8cb"),
                column: "Created_at",
                value: "8/12/2023 1:30:58 AM");

            migrationBuilder.UpdateData(
                table: "UnitMeasures",
                keyColumn: "Id",
                keyValue: new Guid("92743a31-78d1-4e8a-eb94-08db979fe8cb"),
                column: "Created_at",
                value: "8/12/2023 1:30:58 AM");
        }
    }
}
