using System.Collections.Generic;

namespace CustomerInformation.Data.Models
{
    public class Address
    {
        public int Id { get; set; }

        public string HomeAddress { get; set; }

        public string OfficeAddress { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        public ICollection<PhoneNumber> PhoneNumbers { get; set; }
    }
}
