using CustomerInformation.Models.Addresses;
using System.Collections.Generic;

namespace CustomerInformation.Models.Customers
{

    public class CustomerUpdateModel
    {
        public int CustomerId { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public int HomeAddressId { get; set; }
        public string HomeAddress { get; set; }

        public int OfficeAddressId { get; set; }
        public string OfficeAddress { get; set; }

        public int HomePhoneId { get; set; }
        public string HomePhoneNumber { get; set; }

        public int OfficePhoneId { get; set; }
        public string OfficePhoneNumber { get; set; }
    }
}
