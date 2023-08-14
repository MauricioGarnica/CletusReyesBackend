using System.ComponentModel.DataAnnotations;

namespace CletusReyes.Models.DTO.User
{
    public class UpdateUserRequestDomainModel
    {
        [MaxLength(10)]
        public string PhoneNumber { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string State { get; set; }

        public string PostalCode { get; set; }

        public string Address { get; set; }

        public string Birthday { get; set; }
    }
}
