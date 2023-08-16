using CletusReyes.Data;
using CletusReyes.Models.Domain_Model.Analytical;
using Microsoft.EntityFrameworkCore;

namespace CletusReyes.Repositories.Analytical
{
    public class SQLAnalyticalRepository : IAnalyticalRepository
    {
        private readonly CletusReyesData data;

        public SQLAnalyticalRepository(CletusReyesData data)
        {
            this.data = data;
        }

        public async Task<List<TblClientesVenta>> GetClientesVentas(int? mes)
        {
            return mes == null ? await data.ClientesVentas.OrderByDescending(opt => opt.TotalVentas).Take(10).ToListAsync() : await data.ClientesVentas.Where(opt => opt.Mes == mes).ToListAsync();
        }

        public async Task<List<TblMateriaComprada>> GetMateriaComprada(int? mes)
        {
            return mes == null ? await data.MateriaComprada.OrderByDescending(opt => opt.SumaMateria).Take(10).ToListAsync() : await data.MateriaComprada.Where(opt => opt.Mes == mes).ToListAsync();
        }

        public async Task<List<TblProductosVendidos>> GetProductosVendidos(int? mes)
        {
            return mes == null ? await data.ProductosVendidos.OrderByDescending(opt => opt.SumaProductos).Take(10).ToListAsync() : await data.ProductosVendidos.Where(opt => opt.Mes == mes).ToListAsync();
        }

        public async Task<List<TblProveedoresCompra>> GetProveedoresCompras(int? mes)
        {
            return mes == null ? await data.ProveedoresCompras.OrderByDescending(opt => opt.TotalCompras).Take(10).ToListAsync() : await data.ProveedoresCompras.Where(opt => opt.Mes == mes).ToListAsync();
        }

        public async Task<List<TblTotalCompras>> GetTotalCompras(int? mes)
        {
            return mes == null ? await data.TotalCompras.OrderByDescending(opt => opt.TotalCompras).Take(10).ToListAsync() : await data.TotalCompras.Where(opt => opt.Mes == mes).ToListAsync();
        }

        public async Task<List<TblTotalGastos>> GetTotalGastos(int? mes)
        {
            return mes == null ? await data.TotalGastos.OrderByDescending(opt => opt.TotalGastos).Take(10).ToListAsync() : await data.TotalGastos.Where(opt => opt.Mes == mes).ToListAsync();
        }

        public async Task<List<TblTotalIngresos>> GetTotalIngresos(int? mes)
        {
            return mes == null ? await data.TotalIngresos.OrderByDescending(opt => opt.TotalIngresos).Take(10).ToListAsync() : await data.TotalIngresos.Where(opt => opt.Mes == mes).ToListAsync();
        }

        public async Task<List<TblTotalVentas>> GetTotalVentas(int? mes)
        {
            return mes == null ? await data.TotalVentas.OrderByDescending(opt => opt.TotalVentas).Take(10).ToListAsync() : await data.TotalVentas.Where(opt => opt.Mes == mes).ToListAsync();
        }
    }
}
