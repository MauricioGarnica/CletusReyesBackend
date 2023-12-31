﻿namespace CletusReyes.Models.DTO.Provider
{
    public class UpdateProviderRequestDomainModel
    {
        public string BusinessName { get; set; }
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }
        public string Address { get; set; }
        public string? UserIdUpdated { get; set; }
    }
}
