namespace CletusReyes.Models.Domain_Model.Analytical
{
    public class TblClientesVenta
    {
        public int Id { get; set; }
        public int TotalVentas { get; set; }
        public string NombrePersona { get; set; }
        public int Mes { get; set; }
        public int Anio { get; set; }
    }
}
