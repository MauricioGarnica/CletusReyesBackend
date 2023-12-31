﻿namespace CletusReyes.Models.DTO.Raw_Material
{
    public class AddRawMaterialRequestDomainModel
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public Guid ProviderId { get; set; }
        public Guid UnitMeasureId { get; set; }
        public float MinValue { get; set; }
        public float MaxValue { get; set; }
        public float Quantity { get; set; }
        public string? UserIdCreated { get; set; }
    }
}
