namespace CletusReyes.Models.DTO.User
{
    public class PersonResponseDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PostalCode { get; set; }
        public string Address { get; set; }
        public string Birthday { get; set; }
        public string Rol { get; set; }
        public string Token { get; set; }

        public UserResponseDto User { get; set; }
    }
}
