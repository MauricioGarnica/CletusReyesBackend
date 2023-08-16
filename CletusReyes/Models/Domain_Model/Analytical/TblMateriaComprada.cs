namespace CletusReyes.Models.Domain_Model.Analytical
{
    public class TblMateriaComprada
    {
        public int Id { get; set; }
        public float SumaMateria { get; set; }
        public string NombreMateria { get; set; }
        public int Mes { get; set; }
        public int Anio { get; set; }
    }
}
