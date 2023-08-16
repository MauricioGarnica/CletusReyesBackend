namespace CletusReyes.Models.Domain_Model.Analytical
{
    public class TblProductosVendidos
    {
        public int Id { get; set; }
        public float SumaProductos { get; set; }
        public string NombreProducto { get; set; }
        public int Mes { get; set; }
        public int Anio { get; set; }
    }
}
