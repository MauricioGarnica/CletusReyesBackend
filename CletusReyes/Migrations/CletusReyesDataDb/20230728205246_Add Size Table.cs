using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CletusReyes.Migrations.CletusReyesDataDb
{
    /// <inheritdoc />
    public partial class AddSizeTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdCreated = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Updated_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserIdUpdated = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "Created_at", "Size", "Status", "Updated_at", "UserIdCreated", "UserIdUpdated" },
                values: new object[,]
                {
                    { new Guid("1afcad04-bae2-4edd-a936-7eea79380149"), null, "14oz", true, null, null, null },
                    { new Guid("24d0f481-814c-41b3-b0d8-4c875d89a95d"), null, "16oz", true, null, null, null },
                    { new Guid("4847982e-f6e4-4d30-acfa-d4d3eb774025"), null, "12oz", true, null, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sizes");
        }
    }
}
