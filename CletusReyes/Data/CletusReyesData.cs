using CletusReyes.Models.Domain_Model.Analytical;
using Microsoft.EntityFrameworkCore;

namespace CletusReyes.Data
{
    public class CletusReyesData : DbContext
    {
        public CletusReyesData(DbContextOptions<CletusReyesData> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<TblClientesVenta> ClientesVentas { get; set; }
        public DbSet<TblMateriaComprada> MateriaComprada { get; set; }
        public DbSet<TblProductosVendidos> ProductosVendidos { get; set; }
        public DbSet<TblProveedoresCompra> ProveedoresCompras { get; set; }
        public DbSet<TblTotalCompras> TotalCompras { get; set; }
        public DbSet<TblTotalGastos> TotalGastos { get; set; }
        public DbSet<TblTotalIngresos> TotalIngresos { get; set; }
        public DbSet<TblTotalVentas> TotalVentas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
