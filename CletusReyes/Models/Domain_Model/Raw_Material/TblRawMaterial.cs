namespace CletusReyes.Models.Domain_Model.Raw_Material
{
    public class TblRawMaterial
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool Status { get; set; }

    }
}
