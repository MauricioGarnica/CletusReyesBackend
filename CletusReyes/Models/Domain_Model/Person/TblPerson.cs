using CletusReyes.Models.Domain_Model.Auth;

namespace CletusReyes.Models.Domain_Model.Person
{
    public class TblPerson
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PostalCode { get; set; }
        public string Address { get; set; }
        public string Birthday { get; set; }
        public string UserId { get; set; }


        public TblUser User { get; set; }
    }
}
