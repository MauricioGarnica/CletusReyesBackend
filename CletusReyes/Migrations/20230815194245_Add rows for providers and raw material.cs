using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CletusReyes.Migrations
{
    /// <inheritdoc />
    public partial class Addrowsforprovidersandrawmaterial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("35e3e543-5807-4805-890e-1d257fbeeee7"),
                column: "Created_at",
                value: "15/08/2023 01:42:45 p. m.");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3f98d5d2-f4be-4e0a-9b07-07f212973b0d"),
                column: "Created_at",
                value: "15/08/2023 01:42:45 p. m.");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("68598c64-99c6-487c-b0f8-c0044c137596"),
                column: "Created_at",
                value: "15/08/2023 01:42:45 p. m.");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f63758e5-61e2-4bf3-925c-0cf137216fe6"),
                column: "Created_at",
                value: "15/08/2023 01:42:45 p. m.");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ffbf969b-36bb-47b3-a3ee-840523779c01"),
                column: "Created_at",
                value: "15/08/2023 01:42:45 p. m.");

            migrationBuilder.InsertData(
                table: "Providers",
                columns: new[] { "Id", "Address", "BusinessName", "ContactEmail", "ContactName", "ContactPhone", "Created_at", "Status", "Updated_at", "UserIdCreated", "UserIdUpdated" },
                values: new object[,]
                {
                    { new Guid("2802ecd1-0b0f-46d0-8cd8-bb94be233e9e"), "Blvd. Hermenegildo Bustos #2217 col.Unidad Obrera Infonavit", "Hilos Modiz", "modiz@gmail.com", "Araceli Gutierrez", "4777180275", "15/08/2023 01:42:45 p. m.", true, null, null, null },
                    { new Guid("32a9172e-d7fd-4b44-83cc-48bfed5a80a1"), "Blvd. Torres Landa #3301 Col.Arroyo Hondo", "Medina Torres", "info@medinatorres.com", "Juan Medina", "4777181780", "15/08/2023 01:42:45 p. m.", true, null, null, null },
                    { new Guid("4e097db4-5534-4d4b-b16c-4ce2550d9d32"), "Blvd.Antonio Madrazo #1216 Col.El Cortijo", "Espumax", "espumax@gmail.com", "Ivan Sanchez", "4772335162", "15/08/2023 01:42:45 p. m.", true, null, null, null },
                    { new Guid("66398fad-6c5a-4608-9a3e-dc9b58be6cf5"), "Blvd.Timoteo Lozano #101-B Col.San Miguel", "Simon Quimica", "ventassq@simonquimica.mx", "Erika Serrato", "4777705252", "15/08/2023 01:42:45 p. m.", true, null, null, null },
                    { new Guid("753ff726-1613-4e81-b936-39ecd53259d1"), "Boulevard Prolongación Tepeyac #1304 local 2 Col. Prados Verdes", "Velcro Brand", "btlalolini@prodigy.net.mx", "Bruno Tlalolini", "4777747540", "15/08/2023 01:42:45 p. m.", true, null, null, null },
                    { new Guid("cc1fa6e7-bee4-4e34-b427-f26ebb6314c8"), "Av.Transportistas #301 Col.Unidad Obrera", "Lefarc", "mercadotecnia@lefarc.com", "Alonso Hernandez", "4774702828", "15/08/2023 01:42:45 p. m.", true, null, null, null },
                    { new Guid("e1174f5b-5e16-4bc1-8c31-7e8e89e6022e"), "Monte Carmelo #112 Col.Arroyo Hondo", "Curtiembres de México", "info@curtiembresdemexico.com", "Sebastian Perez", "4777780079", "15/08/2023 01:42:45 p. m.", true, null, null, null }
                });

            migrationBuilder.UpdateData(
                table: "PurchaseOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("196f0047-4231-4160-8d4e-124b8437dfac"),
                column: "Created_at",
                value: "15/08/2023 01:42:45 p. m.");

            migrationBuilder.UpdateData(
                table: "PurchaseOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("5e257c72-e959-4d0d-9894-1c8682515a3a"),
                column: "Created_at",
                value: "15/08/2023 01:42:45 p. m.");

            migrationBuilder.UpdateData(
                table: "PurchaseOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("6967f493-61ef-41af-b785-a9a8649e8767"),
                column: "Created_at",
                value: "15/08/2023 01:42:45 p. m.");

            migrationBuilder.UpdateData(
                table: "PurchaseOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("e2d2d115-764b-4264-a6a9-4a1f4d5f4dd4"),
                column: "Created_at",
                value: "15/08/2023 01:42:45 p. m.");

            migrationBuilder.UpdateData(
                table: "SaleOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("25a4b068-bc82-4684-8bc5-5c4087d487e4"),
                column: "Created_at",
                value: "15/08/2023 01:42:45 p. m.");

            migrationBuilder.UpdateData(
                table: "SaleOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("34e82473-b511-4b31-a94e-304130ee2ede"),
                column: "Created_at",
                value: "15/08/2023 01:42:45 p. m.");

            migrationBuilder.UpdateData(
                table: "SaleOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("aeb24d0e-7e62-4183-ace1-4401939ddce6"),
                column: "Created_at",
                value: "15/08/2023 01:42:45 p. m.");

            migrationBuilder.UpdateData(
                table: "SaleOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("bf341b19-7e2e-492e-8aef-ebab9c33fe09"),
                column: "Created_at",
                value: "15/08/2023 01:42:45 p. m.");

            migrationBuilder.UpdateData(
                table: "SaleOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("cb22b5ba-8792-4675-88bb-e33beb098b7d"),
                column: "Created_at",
                value: "15/08/2023 01:42:45 p. m.");

            migrationBuilder.UpdateData(
                table: "SaleOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("d5f1c029-61cf-4273-a3d7-431c110e4f15"),
                column: "Created_at",
                value: "15/08/2023 01:42:45 p. m.");

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("1afcad04-bae2-4edd-a936-7eea79380149"),
                column: "Created_at",
                value: "15/08/2023 01:42:45 p. m.");

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("24d0f481-814c-41b3-b0d8-4c875d89a95d"),
                column: "Created_at",
                value: "15/08/2023 01:42:45 p. m.");

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("4847982e-f6e4-4d30-acfa-d4d3eb774025"),
                column: "Created_at",
                value: "15/08/2023 01:42:45 p. m.");

            migrationBuilder.UpdateData(
                table: "UnitMeasures",
                keyColumn: "Id",
                keyValue: new Guid("7220fd18-43fe-4880-eb95-08db979fe8cb"),
                column: "Created_at",
                value: "15/08/2023 01:42:45 p. m.");

            migrationBuilder.UpdateData(
                table: "UnitMeasures",
                keyColumn: "Id",
                keyValue: new Guid("92743a31-78d1-4e8a-eb94-08db979fe8cb"),
                column: "Created_at",
                value: "15/08/2023 01:42:45 p. m.");

            migrationBuilder.InsertData(
                table: "RawMaterials",
                columns: new[] { "Id", "Created_at", "Description", "MaxValue", "MinValue", "Name", "Price", "ProviderId", "Quantity", "Status", "UnitMeasureId", "Updated_at", "UserIdCreated", "UserIdUpdated" },
                values: new object[,]
                {
                    { new Guid("250b5182-f96d-422f-9efd-0afd55221143"), "15/08/2023 01:42:45 p. m.", "", 10000f, 200f, "Hilo negro", 100.0, new Guid("2802ecd1-0b0f-46d0-8cd8-bb94be233e9e"), 5000f, true, new Guid("92743a31-78d1-4e8a-eb94-08db979fe8cb"), null, null, null },
                    { new Guid("5ce0a50e-d43f-479c-a51d-5792c2405555"), "15/08/2023 01:42:45 p. m.", "", 100f, 5f, "Goma espuma de 100*100cm", 350.0, new Guid("4e097db4-5534-4d4b-b16c-4ce2550d9d32"), 56f, true, new Guid("7220fd18-43fe-4880-eb95-08db979fe8cb"), null, null, null },
                    { new Guid("5eb8fffa-c508-47a6-a662-0452993ea114"), "15/08/2023 01:42:45 p. m.", "", 40000f, 2000f, "Piel de vaca color blanco", 375.0, new Guid("32a9172e-d7fd-4b44-83cc-48bfed5a80a1"), 20000f, true, new Guid("92743a31-78d1-4e8a-eb94-08db979fe8cb"), null, null, null },
                    { new Guid("758a1a4e-c7f8-4058-a7c4-2602c0298b32"), "15/08/2023 01:42:45 p. m.", "", 30000f, 1500f, "Piel de vaca color rojo", 350.0, new Guid("32a9172e-d7fd-4b44-83cc-48bfed5a80a1"), 15000f, true, new Guid("92743a31-78d1-4e8a-eb94-08db979fe8cb"), null, null, null },
                    { new Guid("f11ccf0f-f8e9-4fda-8677-6992dd53a64b"), "15/08/2023 01:42:45 p. m.", "", 20000f, 1000f, "Piel de vaca color negro", 325.0, new Guid("32a9172e-d7fd-4b44-83cc-48bfed5a80a1"), 7000f, true, new Guid("92743a31-78d1-4e8a-eb94-08db979fe8cb"), null, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: new Guid("66398fad-6c5a-4608-9a3e-dc9b58be6cf5"));

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: new Guid("753ff726-1613-4e81-b936-39ecd53259d1"));

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: new Guid("cc1fa6e7-bee4-4e34-b427-f26ebb6314c8"));

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: new Guid("e1174f5b-5e16-4bc1-8c31-7e8e89e6022e"));

            migrationBuilder.DeleteData(
                table: "RawMaterials",
                keyColumn: "Id",
                keyValue: new Guid("250b5182-f96d-422f-9efd-0afd55221143"));

            migrationBuilder.DeleteData(
                table: "RawMaterials",
                keyColumn: "Id",
                keyValue: new Guid("5ce0a50e-d43f-479c-a51d-5792c2405555"));

            migrationBuilder.DeleteData(
                table: "RawMaterials",
                keyColumn: "Id",
                keyValue: new Guid("5eb8fffa-c508-47a6-a662-0452993ea114"));

            migrationBuilder.DeleteData(
                table: "RawMaterials",
                keyColumn: "Id",
                keyValue: new Guid("758a1a4e-c7f8-4058-a7c4-2602c0298b32"));

            migrationBuilder.DeleteData(
                table: "RawMaterials",
                keyColumn: "Id",
                keyValue: new Guid("f11ccf0f-f8e9-4fda-8677-6992dd53a64b"));

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: new Guid("2802ecd1-0b0f-46d0-8cd8-bb94be233e9e"));

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: new Guid("32a9172e-d7fd-4b44-83cc-48bfed5a80a1"));

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "Id",
                keyValue: new Guid("4e097db4-5534-4d4b-b16c-4ce2550d9d32"));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("35e3e543-5807-4805-890e-1d257fbeeee7"),
                column: "Created_at",
                value: "8/14/2023 12:14:09 AM");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3f98d5d2-f4be-4e0a-9b07-07f212973b0d"),
                column: "Created_at",
                value: "8/14/2023 12:14:09 AM");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("68598c64-99c6-487c-b0f8-c0044c137596"),
                column: "Created_at",
                value: "8/14/2023 12:14:09 AM");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f63758e5-61e2-4bf3-925c-0cf137216fe6"),
                column: "Created_at",
                value: "8/14/2023 12:14:09 AM");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ffbf969b-36bb-47b3-a3ee-840523779c01"),
                column: "Created_at",
                value: "8/14/2023 12:14:09 AM");

            migrationBuilder.UpdateData(
                table: "PurchaseOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("196f0047-4231-4160-8d4e-124b8437dfac"),
                column: "Created_at",
                value: "8/14/2023 12:14:09 AM");

            migrationBuilder.UpdateData(
                table: "PurchaseOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("5e257c72-e959-4d0d-9894-1c8682515a3a"),
                column: "Created_at",
                value: "8/14/2023 12:14:09 AM");

            migrationBuilder.UpdateData(
                table: "PurchaseOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("6967f493-61ef-41af-b785-a9a8649e8767"),
                column: "Created_at",
                value: "8/14/2023 12:14:09 AM");

            migrationBuilder.UpdateData(
                table: "PurchaseOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("e2d2d115-764b-4264-a6a9-4a1f4d5f4dd4"),
                column: "Created_at",
                value: "8/14/2023 12:14:09 AM");

            migrationBuilder.UpdateData(
                table: "SaleOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("25a4b068-bc82-4684-8bc5-5c4087d487e4"),
                column: "Created_at",
                value: "8/14/2023 12:14:09 AM");

            migrationBuilder.UpdateData(
                table: "SaleOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("34e82473-b511-4b31-a94e-304130ee2ede"),
                column: "Created_at",
                value: "8/14/2023 12:14:09 AM");

            migrationBuilder.UpdateData(
                table: "SaleOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("aeb24d0e-7e62-4183-ace1-4401939ddce6"),
                column: "Created_at",
                value: "8/14/2023 12:14:09 AM");

            migrationBuilder.UpdateData(
                table: "SaleOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("bf341b19-7e2e-492e-8aef-ebab9c33fe09"),
                column: "Created_at",
                value: "8/14/2023 12:14:09 AM");

            migrationBuilder.UpdateData(
                table: "SaleOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("cb22b5ba-8792-4675-88bb-e33beb098b7d"),
                column: "Created_at",
                value: "8/14/2023 12:14:09 AM");

            migrationBuilder.UpdateData(
                table: "SaleOrderStatus",
                keyColumn: "Id",
                keyValue: new Guid("d5f1c029-61cf-4273-a3d7-431c110e4f15"),
                column: "Created_at",
                value: "8/14/2023 12:14:09 AM");

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("1afcad04-bae2-4edd-a936-7eea79380149"),
                column: "Created_at",
                value: "8/14/2023 12:14:09 AM");

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("24d0f481-814c-41b3-b0d8-4c875d89a95d"),
                column: "Created_at",
                value: "8/14/2023 12:14:09 AM");

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("4847982e-f6e4-4d30-acfa-d4d3eb774025"),
                column: "Created_at",
                value: "8/14/2023 12:14:09 AM");

            migrationBuilder.UpdateData(
                table: "UnitMeasures",
                keyColumn: "Id",
                keyValue: new Guid("7220fd18-43fe-4880-eb95-08db979fe8cb"),
                column: "Created_at",
                value: "8/14/2023 12:14:09 AM");

            migrationBuilder.UpdateData(
                table: "UnitMeasures",
                keyColumn: "Id",
                keyValue: new Guid("92743a31-78d1-4e8a-eb94-08db979fe8cb"),
                column: "Created_at",
                value: "8/14/2023 12:14:09 AM");
        }
    }
}
