namespace CletusReyes.Models.Domain_Model.Analytical
{
    public class TblProveedoresCompra
    {
        public int Id { get; set; }
        public float TotalCompras { get; set; }
        public string NombreProveedor { get; set; }
        public int Mes { get; set; }
        public int Anio { get; set; }
    }
}
