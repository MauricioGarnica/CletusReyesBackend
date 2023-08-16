using CletusReyes.Models.Domain_Model.Analytical;

namespace CletusReyes.Repositories.Analytical
{
    public interface IAnalyticalRepository
    {
        Task<List<TblClientesVenta>> GetClientesVentas(int? mes);
        Task<List<TblMateriaComprada>> GetMateriaComprada(int? mes);
        Task<List<TblProductosVendidos>> GetProductosVendidos(int? mes);
        Task<List<TblProveedoresCompra>> GetProveedoresCompras(int? mes);
        Task<List<TblTotalCompras>> GetTotalCompras(int? mes);
        Task<List<TblTotalGastos>> GetTotalGastos(int? mes);
        Task<List<TblTotalIngresos>> GetTotalIngresos(int? mes);
        Task<List<TblTotalVentas>> GetTotalVentas(int? mes);
    }
}
