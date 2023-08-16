using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CletusReyes.Migrations
{
    /// <inheritdoc />
    public partial class AddrowsforproductsIV : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("83a96764-b2e4-4794-8f0a-69de7fe48143"));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("35e3e543-5807-4805-890e-1d257fbeeee7"),
                column: "Created_at",
                value: "8/15/2023 4:58:39 PM");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3f98d5d2-f4be-4e0a-9b07-07f212973b0d"),
                column: "Created_at",
                value: "8/15/2023 4:58:39 PM");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("68598c64-99c6-487c-b0f8-c0044c137596"),
                column: "Created_at",
                value: "8/15/2023 4:58:39 PM");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f63758e5-61e2-4bf3-925c-0cf137216fe6"),
                column: "Created_at",
                value: "8/15/2023 4:58:39 PM");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ffbf969b-36bb-47b3-a3ee-840523779c01"),
                column: "Created_at",
                value: "8/15/2023 4:58:39 PM");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("05ca4c98-738a-47d0-ad57-0837f79042d6"),
                column: "Created_at",
                value: "8/15/2023 4:58:39 PM");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1432c9e0-c549-4e9d-8586-a8cabc81fbae"),
                column: "Created_at",
                value: "8/15/2023 4:58:39 PM");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4175f4ae-4750-4ceb-bfa8-7ff83b0a1d7e"),
                column: "Created_at",
                value: "8/15/2023 4:58:39 PM");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("45715fa2-fdb2-4ced-8c21-76d71f374037"),
                column: "Created_at",
                value: "8/15/2023 4:58:39 PM");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6aa0de18-fa8b-4070-a4dc-79cec6e1e700"),
                column: "Created_at",
                value: "8/15/2023 4:58:39 PM");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6cbd63b4-f0c6-4cc8-99ca-6263e150e474"),
                column: "Created_at",
                value: "8/15/2023 4:58:39 PM");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9591d94e-2a82-49c5-ad1f-2dd1b7fa6837"),
                column: "Created_at",
                value: "8/15/2023 4:58:39 PM");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9d1801c2-52f1-425d-bf45-67eedcfc4179"),
                column: "Created_at",
                value: "8/15/2023 4:58:39 PM");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b028a88c-80ea-4b62-8a45-4059d5dedf01"),
                column: "Created_at",
                value: "8/15/2023 4:58:39 PM");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b9aa5ff6-9eac-4853-aaef-3e9ac0e77329"),
                column: "Created_at",
                value: "8/15/2023 4:58:39 PM");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d13a1ae6-4dc0-4bb3-bf1d-184ac3d18885"),
                column: "Created_at",
                value: "8/15/2023 4:58:39 PM");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fc000f09-4a69-4937-b7b0-80215b37de73"),
                column: "Created_at",
                value: "8/15/2023 4:58:39 PM");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Created_at", "Description", "FileDescription", "FileExtension", "FileName", "FilePath", "FileSizeInBytes", "MaxValue", "MinValue", "Name", "Price", "Quantity", "SizeId", "Status", "Updated_at", "UserIdCreated", "UserIdUpdated" },
                values: new object[,]
                {
                    { new Guid("17ed600e-4634-474d-b58d-a20085f0fa05"), new Guid("3f98d5d2-f4be-4e0a-9b07-07f212973b0d"), "8/15/2023 4:58:39 PM", "", "", ".jpg", "Caretablancachica", "https://localhost:7088/Images/Caretablancachica.jpg", 0L, 25, 5, "Careta blanca chica", 1000.0, 10, new Guid("98838e4b-fae5-4ae8-9cc3-05b794dc322e"), true, null, null, null },
                    { new Guid("2ae73b97-e8a8-4de2-9ad7-e0fbfc583677"), new Guid("3f98d5d2-f4be-4e0a-9b07-07f212973b0d"), "8/15/2023 4:58:39 PM", "", "", ".jpg", "Caretarojachica", "https://localhost:7088/Images/Caretarojachica.jpg", 0L, 25, 5, "Careta roja chica", 1000.0, 10, new Guid("98838e4b-fae5-4ae8-9cc3-05b794dc322e"), true, null, null, null },
                    { new Guid("6528d6ce-e99c-4a78-99f7-20201d8c8aa3"), new Guid("3f98d5d2-f4be-4e0a-9b07-07f212973b0d"), "8/15/2023 4:58:39 PM", "", "", ".jpg", "Caretanegraadulto", "https://localhost:7088/Images/Caretanegraadulto.jpg", 0L, 25, 5, "Careta negra adulto", 1000.0, 10, new Guid("515d8c75-f2f2-4473-8f82-405dedb5d613"), true, null, null, null },
                    { new Guid("94c66e3f-9138-4e41-8bf0-8a31c2241262"), new Guid("3f98d5d2-f4be-4e0a-9b07-07f212973b0d"), "8/15/2023 4:58:39 PM", "", "", ".jpg", "Caretanegrachica", "https://localhost:7088/Images/Caretanegrachica.jpg", 0L, 25, 5, "Careta negra chica", 1000.0, 10, new Guid("98838e4b-fae5-4ae8-9cc3-05b794dc322e"), true, null, null, null },
                    { new Guid("e1095653-b2fd-46c1-8f54-3c4d30a9401a"), new Guid("3f98d5d2-f4be-4e0a-9b07-07f212973b0d"), "8/15/2023 4:58:39 PM", "", "", ".jpg", "Caretarojaadulto", "https://localhost:7088/Images/Caretarojaadulto.jpg", 0L, 25, 5, "Careta roja adulto", 1000.0, 10, new Guid("515d8c75-f2f2-4473-8f82-405dedb5d613"), true, null, null, null },
                    { new Guid("fca25f2b-ec65-4e45-9c4b-9c2351ccebed"), new Guid("3f98d5d2-f4be-4e0a-9b07-07f212973b0d"), "8/15/2023 4:58:39 PM", "", "", ".jpg", "Caretablancaadulto", "https://localhost:7088/Images/Caretablancaadulto.jpg", 0L, 25, 5, "Careta blanca adulto", 1000.0, 10, new Guid("515d8c75-f2f2-4473-8f82-405dedb5d613"), true, null, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: new Guid("2802ecd1-0b0f-46d0-8cd8-bb94be233e9e"),
                column: "Created_at",
                value: "8/15/2023 4:58:39 PM");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: new Guid("32a9172e-d7fd-4b44-83cc-48bfed5a80a1"),
                column: "Created_at",
                value: "8/15/2023 4:58:39 PM");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: new Guid("4e097db4-5534-4d4b-b16c-4ce2550d9d32"),
                column: "Created_at",
                value: "8/15/2023 4:58:39 PM");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: new Guid("66398fad-6c5a-4608-9a3e-dc9b58be6cf5"),
                column: "Created_at",
                value: "8/15/2023 4:58:39 PM");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: new Guid("753ff726-1613-4e81-b936-39ecd53259d1"),
                column: "Created_at",
                value: "8/15/2023 4:58:39 PM");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: new Guid("cc1fa6e7-bee4-4e34-b427-f26ebb6314c8"),
                column: "Created_at",
                value: "8/15/2023 4:58:39 PM");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: new Guid("e1174f5b-5e16-4bc1-8c31-7e8e89e6022e"),
                column: "Created_at",
                value: "8/15/2023 4:58:39 PM");

            migrationBuilder.UpdateData(
                table: "PurchaseOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("196f0047-4231-4160-8d4e-124b8437dfac"),
                column: "Created_at",
                value: "8/15/2023 4:58:39 PM");

            migrationBuilder.UpdateData(
                table: "PurchaseOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("5e257c72-e959-4d0d-9894-1c8682515a3a"),
                column: "Created_at",
                value: "8/15/2023 4:58:39 PM");

            migrationBuilder.UpdateData(
                table: "PurchaseOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("6967f493-61ef-41af-b785-a9a8649e8767"),
                column: "Created_at",
                value: "8/15/2023 4:58:39 PM");

            migrationBuilder.UpdateData(
                table: "PurchaseOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("e2d2d115-764b-4264-a6a9-4a1f4d5f4dd4"),
                column: "Created_at",
                value: "8/15/2023 4:58:39 PM");

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "Id",
                keyValue: new Guid("0056c142-13f2-465d-824d-4299eaa3d45d"),
                column: "Created_at",
                value: "8/15/2023 4:58:39 PM");

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "Id",
                keyValue: new Guid("250b5182-f96d-422f-9efd-0afd55221143"),
                column: "Created_at",
                value: "8/15/2023 4:58:39 PM");

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "Id",
                keyValue: new Guid("279b5ed0-e9e0-4e2c-88fd-176ad5b8847a"),
                column: "Created_at",
                value: "8/15/2023 4:58:39 PM");

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "Id",
                keyValue: new Guid("3bb6c3af-9fcc-462e-9f31-b7a20fd413d4"),
                column: "Created_at",
                value: "8/15/2023 4:58:39 PM");

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "Id",
                keyValue: new Guid("5ce0a50e-d43f-479c-a51d-5792c2405555"),
                column: "Created_at",
                value: "8/15/2023 4:58:39 PM");

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "Id",
                keyValue: new Guid("5eb8fffa-c508-47a6-a662-0452993ea114"),
                column: "Created_at",
                value: "8/15/2023 4:58:39 PM");

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "Id",
                keyValue: new Guid("72294d1e-133a-4c69-9eb9-df383ad49819"),
                column: "Created_at",
                value: "8/15/2023 4:58:39 PM");

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "Id",
                keyValue: new Guid("758a1a4e-c7f8-4058-a7c4-2602c0298b32"),
                column: "Created_at",
                value: "8/15/2023 4:58:39 PM");

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "Id",
                keyValue: new Guid("83e4c615-648c-4405-aed6-bbd084ea105f"),
                column: "Created_at",
                value: "8/15/2023 4:58:39 PM");

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "Id",
                keyValue: new Guid("bb156abe-638f-4243-b338-5f7ed26d2f47"),
                column: "Created_at",
                value: "8/15/2023 4:58:39 PM");

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "Id",
                keyValue: new Guid("bc94f5cf-8b87-4860-8fb4-a5794f06833d"),
                column: "Created_at",
                value: "8/15/2023 4:58:39 PM");

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "Id",
                keyValue: new Guid("d4736685-9730-40fd-a18e-5d7bdff280e2"),
                column: "Created_at",
                value: "8/15/2023 4:58:39 PM");

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "Id",
                keyValue: new Guid("d9fd1206-ccf1-44e6-979d-0d2dac1bccbd"),
                column: "Created_at",
                value: "8/15/2023 4:58:39 PM");

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "Id",
                keyValue: new Guid("db9e6ef4-d516-448d-9c40-1ba7b7b83af2"),
                column: "Created_at",
                value: "8/15/2023 4:58:39 PM");

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "Id",
                keyValue: new Guid("dff9d777-3531-4d9c-abcf-78f4fbff80fa"),
                column: "Created_at",
                value: "8/15/2023 4:58:39 PM");

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "Id",
                keyValue: new Guid("f11ccf0f-f8e9-4fda-8677-6992dd53a64b"),
                column: "Created_at",
                value: "8/15/2023 4:58:39 PM");

            migrationBuilder.UpdateData(
                table: "SaleOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("25a4b068-bc82-4684-8bc5-5c4087d487e4"),
                column: "Created_at",
                value: "8/15/2023 4:58:39 PM");

            migrationBuilder.UpdateData(
                table: "SaleOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("34e82473-b511-4b31-a94e-304130ee2ede"),
                column: "Created_at",
                value: "8/15/2023 4:58:39 PM");

            migrationBuilder.UpdateData(
                table: "SaleOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("aeb24d0e-7e62-4183-ace1-4401939ddce6"),
                column: "Created_at",
                value: "8/15/2023 4:58:39 PM");

            migrationBuilder.UpdateData(
                table: "SaleOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("bf341b19-7e2e-492e-8aef-ebab9c33fe09"),
                column: "Created_at",
                value: "8/15/2023 4:58:39 PM");

            migrationBuilder.UpdateData(
                table: "SaleOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("cb22b5ba-8792-4675-88bb-e33beb098b7d"),
                column: "Created_at",
                value: "8/15/2023 4:58:39 PM");

            migrationBuilder.UpdateData(
                table: "SaleOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("d5f1c029-61cf-4273-a3d7-431c110e4f15"),
                column: "Created_at",
                value: "8/15/2023 4:58:39 PM");

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("1afcad04-bae2-4edd-a936-7eea79380149"),
                column: "Created_at",
                value: "8/15/2023 4:58:39 PM");

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("24d0f481-814c-41b3-b0d8-4c875d89a95d"),
                column: "Created_at",
                value: "8/15/2023 4:58:39 PM");

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("4847982e-f6e4-4d30-acfa-d4d3eb774025"),
                column: "Created_at",
                value: "8/15/2023 4:58:39 PM");

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("515d8c75-f2f2-4473-8f82-405dedb5d613"),
                columns: new[] { "Created_at", "Size" },
                values: new object[] { "8/15/2023 4:58:39 PM", "ADULTO" });

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("98838e4b-fae5-4ae8-9cc3-05b794dc322e"),
                column: "Created_at",
                value: "8/15/2023 4:58:39 PM");

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("e38bff0e-b36d-4dd6-99b6-c23ee4e4a05a"),
                column: "Created_at",
                value: "8/15/2023 4:58:39 PM");

            migrationBuilder.UpdateData(
                table: "UnitMeasures",
                keyColumn: "Id",
                keyValue: new Guid("7220fd18-43fe-4880-eb95-08db979fe8cb"),
                column: "Created_at",
                value: "8/15/2023 4:58:39 PM");

            migrationBuilder.UpdateData(
                table: "UnitMeasures",
                keyColumn: "Id",
                keyValue: new Guid("92743a31-78d1-4e8a-eb94-08db979fe8cb"),
                column: "Created_at",
                value: "8/15/2023 4:58:39 PM");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("17ed600e-4634-474d-b58d-a20085f0fa05"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2ae73b97-e8a8-4de2-9ad7-e0fbfc583677"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6528d6ce-e99c-4a78-99f7-20201d8c8aa3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("94c66e3f-9138-4e41-8bf0-8a31c2241262"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e1095653-b2fd-46c1-8f54-3c4d30a9401a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fca25f2b-ec65-4e45-9c4b-9c2351ccebed"));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("35e3e543-5807-4805-890e-1d257fbeeee7"),
                column: "Created_at",
                value: "8/15/2023 4:33:43 PM");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3f98d5d2-f4be-4e0a-9b07-07f212973b0d"),
                column: "Created_at",
                value: "8/15/2023 4:33:43 PM");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("68598c64-99c6-487c-b0f8-c0044c137596"),
                column: "Created_at",
                value: "8/15/2023 4:33:43 PM");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f63758e5-61e2-4bf3-925c-0cf137216fe6"),
                column: "Created_at",
                value: "8/15/2023 4:33:43 PM");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ffbf969b-36bb-47b3-a3ee-840523779c01"),
                column: "Created_at",
                value: "8/15/2023 4:33:43 PM");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("05ca4c98-738a-47d0-ad57-0837f79042d6"),
                column: "Created_at",
                value: "8/15/2023 4:33:43 PM");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1432c9e0-c549-4e9d-8586-a8cabc81fbae"),
                column: "Created_at",
                value: "8/15/2023 4:33:43 PM");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4175f4ae-4750-4ceb-bfa8-7ff83b0a1d7e"),
                column: "Created_at",
                value: "8/15/2023 4:33:43 PM");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("45715fa2-fdb2-4ced-8c21-76d71f374037"),
                column: "Created_at",
                value: "8/15/2023 4:33:43 PM");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6aa0de18-fa8b-4070-a4dc-79cec6e1e700"),
                column: "Created_at",
                value: "8/15/2023 4:33:43 PM");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6cbd63b4-f0c6-4cc8-99ca-6263e150e474"),
                column: "Created_at",
                value: "8/15/2023 4:33:43 PM");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9591d94e-2a82-49c5-ad1f-2dd1b7fa6837"),
                column: "Created_at",
                value: "8/15/2023 4:33:43 PM");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9d1801c2-52f1-425d-bf45-67eedcfc4179"),
                column: "Created_at",
                value: "8/15/2023 4:33:43 PM");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b028a88c-80ea-4b62-8a45-4059d5dedf01"),
                column: "Created_at",
                value: "8/15/2023 4:33:43 PM");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b9aa5ff6-9eac-4853-aaef-3e9ac0e77329"),
                column: "Created_at",
                value: "8/15/2023 4:33:43 PM");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d13a1ae6-4dc0-4bb3-bf1d-184ac3d18885"),
                column: "Created_at",
                value: "8/15/2023 4:33:43 PM");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fc000f09-4a69-4937-b7b0-80215b37de73"),
                column: "Created_at",
                value: "8/15/2023 4:33:43 PM");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: new Guid("2802ecd1-0b0f-46d0-8cd8-bb94be233e9e"),
                column: "Created_at",
                value: "8/15/2023 4:33:43 PM");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: new Guid("32a9172e-d7fd-4b44-83cc-48bfed5a80a1"),
                column: "Created_at",
                value: "8/15/2023 4:33:43 PM");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: new Guid("4e097db4-5534-4d4b-b16c-4ce2550d9d32"),
                column: "Created_at",
                value: "8/15/2023 4:33:43 PM");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: new Guid("66398fad-6c5a-4608-9a3e-dc9b58be6cf5"),
                column: "Created_at",
                value: "8/15/2023 4:33:43 PM");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: new Guid("753ff726-1613-4e81-b936-39ecd53259d1"),
                column: "Created_at",
                value: "8/15/2023 4:33:43 PM");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: new Guid("cc1fa6e7-bee4-4e34-b427-f26ebb6314c8"),
                column: "Created_at",
                value: "8/15/2023 4:33:43 PM");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: new Guid("e1174f5b-5e16-4bc1-8c31-7e8e89e6022e"),
                column: "Created_at",
                value: "8/15/2023 4:33:43 PM");

            migrationBuilder.UpdateData(
                table: "PurchaseOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("196f0047-4231-4160-8d4e-124b8437dfac"),
                column: "Created_at",
                value: "8/15/2023 4:33:43 PM");

            migrationBuilder.UpdateData(
                table: "PurchaseOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("5e257c72-e959-4d0d-9894-1c8682515a3a"),
                column: "Created_at",
                value: "8/15/2023 4:33:43 PM");

            migrationBuilder.UpdateData(
                table: "PurchaseOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("6967f493-61ef-41af-b785-a9a8649e8767"),
                column: "Created_at",
                value: "8/15/2023 4:33:43 PM");

            migrationBuilder.UpdateData(
                table: "PurchaseOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("e2d2d115-764b-4264-a6a9-4a1f4d5f4dd4"),
                column: "Created_at",
                value: "8/15/2023 4:33:43 PM");

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "Id",
                keyValue: new Guid("0056c142-13f2-465d-824d-4299eaa3d45d"),
                column: "Created_at",
                value: "8/15/2023 4:33:43 PM");

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "Id",
                keyValue: new Guid("250b5182-f96d-422f-9efd-0afd55221143"),
                column: "Created_at",
                value: "8/15/2023 4:33:43 PM");

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "Id",
                keyValue: new Guid("279b5ed0-e9e0-4e2c-88fd-176ad5b8847a"),
                column: "Created_at",
                value: "8/15/2023 4:33:43 PM");

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "Id",
                keyValue: new Guid("3bb6c3af-9fcc-462e-9f31-b7a20fd413d4"),
                column: "Created_at",
                value: "8/15/2023 4:33:43 PM");

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "Id",
                keyValue: new Guid("5ce0a50e-d43f-479c-a51d-5792c2405555"),
                column: "Created_at",
                value: "8/15/2023 4:33:43 PM");

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "Id",
                keyValue: new Guid("5eb8fffa-c508-47a6-a662-0452993ea114"),
                column: "Created_at",
                value: "8/15/2023 4:33:43 PM");

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "Id",
                keyValue: new Guid("72294d1e-133a-4c69-9eb9-df383ad49819"),
                column: "Created_at",
                value: "8/15/2023 4:33:43 PM");

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "Id",
                keyValue: new Guid("758a1a4e-c7f8-4058-a7c4-2602c0298b32"),
                column: "Created_at",
                value: "8/15/2023 4:33:43 PM");

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "Id",
                keyValue: new Guid("83e4c615-648c-4405-aed6-bbd084ea105f"),
                column: "Created_at",
                value: "8/15/2023 4:33:43 PM");

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "Id",
                keyValue: new Guid("bb156abe-638f-4243-b338-5f7ed26d2f47"),
                column: "Created_at",
                value: "8/15/2023 4:33:43 PM");

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "Id",
                keyValue: new Guid("bc94f5cf-8b87-4860-8fb4-a5794f06833d"),
                column: "Created_at",
                value: "8/15/2023 4:33:43 PM");

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "Id",
                keyValue: new Guid("d4736685-9730-40fd-a18e-5d7bdff280e2"),
                column: "Created_at",
                value: "8/15/2023 4:33:43 PM");

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "Id",
                keyValue: new Guid("d9fd1206-ccf1-44e6-979d-0d2dac1bccbd"),
                column: "Created_at",
                value: "8/15/2023 4:33:43 PM");

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "Id",
                keyValue: new Guid("db9e6ef4-d516-448d-9c40-1ba7b7b83af2"),
                column: "Created_at",
                value: "8/15/2023 4:33:43 PM");

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "Id",
                keyValue: new Guid("dff9d777-3531-4d9c-abcf-78f4fbff80fa"),
                column: "Created_at",
                value: "8/15/2023 4:33:43 PM");

            migrationBuilder.UpdateData(
                table: "RawMaterials",
                keyColumn: "Id",
                keyValue: new Guid("f11ccf0f-f8e9-4fda-8677-6992dd53a64b"),
                column: "Created_at",
                value: "8/15/2023 4:33:43 PM");

            migrationBuilder.UpdateData(
                table: "SaleOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("25a4b068-bc82-4684-8bc5-5c4087d487e4"),
                column: "Created_at",
                value: "8/15/2023 4:33:43 PM");

            migrationBuilder.UpdateData(
                table: "SaleOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("34e82473-b511-4b31-a94e-304130ee2ede"),
                column: "Created_at",
                value: "8/15/2023 4:33:43 PM");

            migrationBuilder.UpdateData(
                table: "SaleOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("aeb24d0e-7e62-4183-ace1-4401939ddce6"),
                column: "Created_at",
                value: "8/15/2023 4:33:43 PM");

            migrationBuilder.UpdateData(
                table: "SaleOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("bf341b19-7e2e-492e-8aef-ebab9c33fe09"),
                column: "Created_at",
                value: "8/15/2023 4:33:43 PM");

            migrationBuilder.UpdateData(
                table: "SaleOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("cb22b5ba-8792-4675-88bb-e33beb098b7d"),
                column: "Created_at",
                value: "8/15/2023 4:33:43 PM");

            migrationBuilder.UpdateData(
                table: "SaleOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("d5f1c029-61cf-4273-a3d7-431c110e4f15"),
                column: "Created_at",
                value: "8/15/2023 4:33:43 PM");

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("1afcad04-bae2-4edd-a936-7eea79380149"),
                column: "Created_at",
                value: "8/15/2023 4:33:43 PM");

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("24d0f481-814c-41b3-b0d8-4c875d89a95d"),
                column: "Created_at",
                value: "8/15/2023 4:33:43 PM");

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("4847982e-f6e4-4d30-acfa-d4d3eb774025"),
                column: "Created_at",
                value: "8/15/2023 4:33:43 PM");

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("515d8c75-f2f2-4473-8f82-405dedb5d613"),
                columns: new[] { "Created_at", "Size" },
                values: new object[] { "8/15/2023 4:33:43 PM", "GRANDE" });

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("98838e4b-fae5-4ae8-9cc3-05b794dc322e"),
                column: "Created_at",
                value: "8/15/2023 4:33:43 PM");

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("e38bff0e-b36d-4dd6-99b6-c23ee4e4a05a"),
                column: "Created_at",
                value: "8/15/2023 4:33:43 PM");

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "Created_at", "Description", "Size", "Status", "Updated_at", "UserIdCreated", "UserIdUpdated" },
                values: new object[] { new Guid("83a96764-b2e4-4794-8f0a-69de7fe48143"), "8/15/2023 4:33:43 PM", null, "MEDIANO", true, null, null, null });

            migrationBuilder.UpdateData(
                table: "UnitMeasures",
                keyColumn: "Id",
                keyValue: new Guid("7220fd18-43fe-4880-eb95-08db979fe8cb"),
                column: "Created_at",
                value: "8/15/2023 4:33:43 PM");

            migrationBuilder.UpdateData(
                table: "UnitMeasures",
                keyColumn: "Id",
                keyValue: new Guid("92743a31-78d1-4e8a-eb94-08db979fe8cb"),
                column: "Created_at",
                value: "8/15/2023 4:33:43 PM");
        }
    }
}
