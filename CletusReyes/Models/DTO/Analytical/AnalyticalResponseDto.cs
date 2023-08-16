using CletusReyes.Models.Domain_Model.Analytical;

namespace CletusReyes.Models.DTO.Analytical
{
    public class AnalyticalResponseDto
    {
        public List<TblClientesVenta> GetClientesVentas { get; set; }
        public List<TblMateriaComprada> GetMateriaComprada { get; set; }
        public List<TblProductosVendidos> GetProductosVendidos { get; set; }
        public List<TblProveedoresCompra> GetProveedoresCompras { get; set; }
        public List<TblTotalCompras> GetTotalCompras { get; set; }
        public List<TblTotalGastos> GetTotalGastos { get; set; }
        public List<TblTotalIngresos> GetTotalIngresos { get; set; }
        public List<TblTotalVentas> GetTotalVentas { get; set; }
    }
}
