using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CletusReyes.Migrations.CletusReyesDataDb
{
    /// <inheritdoc />
    public partial class UpdatetableRecipeHeaderandinsertsomerowsfrommanytables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "RecipeHeaders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Created_at", "Description", "Name", "Status", "Updated_at", "UserIdCreated", "UserIdUpdated" },
                values: new object[,]
                {
                    { new Guid("35e3e543-5807-4805-890e-1d257fbeeee7"), null, null, "Ropa y calzado", true, null, null, null },
                    { new Guid("3f98d5d2-f4be-4e0a-9b07-07f212973b0d"), null, null, "Proteccion", true, null, null, null },
                    { new Guid("68598c64-99c6-487c-b0f8-c0044c137596"), null, null, "Costales de box", true, null, null, null },
                    { new Guid("f63758e5-61e2-4bf3-925c-0cf137216fe6"), null, null, "Coaching", true, null, null, null },
                    { new Guid("ffbf969b-36bb-47b3-a3ee-840523779c01"), null, null, "Guantes", true, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "UnitMeasures",
                columns: new[] { "Id", "Created_at", "Name", "Status", "Updated_at", "UserIdCreated", "UserIdUpdated" },
                values: new object[,]
                {
                    { new Guid("7220fd18-43fe-4880-eb95-08db979fe8cb"), null, "PZ", true, null, null, null },
                    { new Guid("92743a31-78d1-4e8a-eb94-08db979fe8cb"), null, "CM", true, null, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("35e3e543-5807-4805-890e-1d257fbeeee7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3f98d5d2-f4be-4e0a-9b07-07f212973b0d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("68598c64-99c6-487c-b0f8-c0044c137596"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f63758e5-61e2-4bf3-925c-0cf137216fe6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ffbf969b-36bb-47b3-a3ee-840523779c01"));

            migrationBuilder.DeleteData(
                table: "UnitMeasures",
                keyColumn: "Id",
                keyValue: new Guid("7220fd18-43fe-4880-eb95-08db979fe8cb"));

            migrationBuilder.DeleteData(
                table: "UnitMeasures",
                keyColumn: "Id",
                keyValue: new Guid("92743a31-78d1-4e8a-eb94-08db979fe8cb"));

            migrationBuilder.DropColumn(
                name: "Name",
                table: "RecipeHeaders");
        }
    }
}
