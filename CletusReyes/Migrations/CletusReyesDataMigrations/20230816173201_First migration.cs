using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CletusReyes.Migrations.CletusReyesDataMigrations
{
    /// <inheritdoc />
    public partial class Firstmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClientesVentas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalVentas = table.Column<int>(type: "int", nullable: false),
                    NombrePersona = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mes = table.Column<int>(type: "int", nullable: false),
                    Anio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientesVentas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MateriaComprada",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SumaMateria = table.Column<float>(type: "real", nullable: false),
                    NombreMateria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mes = table.Column<int>(type: "int", nullable: false),
                    Anio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MateriaComprada", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductosVendidos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SumaProductos = table.Column<float>(type: "real", nullable: false),
                    NombreProducto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mes = table.Column<int>(type: "int", nullable: false),
                    Anio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductosVendidos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProveedoresCompras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalCompras = table.Column<float>(type: "real", nullable: false),
                    NombreProveedor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mes = table.Column<int>(type: "int", nullable: false),
                    Anio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProveedoresCompras", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TotalCompras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalCompras = table.Column<int>(type: "int", nullable: false),
                    Mes = table.Column<int>(type: "int", nullable: false),
                    Anio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TotalCompras", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TotalGastos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalGastos = table.Column<float>(type: "real", nullable: false),
                    Mes = table.Column<int>(type: "int", nullable: false),
                    Anio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TotalGastos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TotalIngresos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalIngresos = table.Column<float>(type: "real", nullable: false),
                    Mes = table.Column<int>(type: "int", nullable: false),
                    Anio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TotalIngresos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TotalVentas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalVentas = table.Column<int>(type: "int", nullable: false),
                    Mes = table.Column<int>(type: "int", nullable: false),
                    Anio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TotalVentas", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientesVentas");

            migrationBuilder.DropTable(
                name: "MateriaComprada");

            migrationBuilder.DropTable(
                name: "ProductosVendidos");

            migrationBuilder.DropTable(
                name: "ProveedoresCompras");

            migrationBuilder.DropTable(
                name: "TotalCompras");

            migrationBuilder.DropTable(
                name: "TotalGastos");

            migrationBuilder.DropTable(
                name: "TotalIngresos");

            migrationBuilder.DropTable(
                name: "TotalVentas");
        }
    }
}
