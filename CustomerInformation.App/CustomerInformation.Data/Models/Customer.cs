using System.Collections.Generic;

namespace CustomerInformation.Data.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public ICollection<Address> Addresses { get; set; }
    }
}
