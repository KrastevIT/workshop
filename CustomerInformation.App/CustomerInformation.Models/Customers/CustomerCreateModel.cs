using CustomerInformation.Models.Addresses;
using System.Collections.Generic;

namespace CustomerInformation.Models.Customers
{
    public class CustomerCreateModel
    {
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public ICollection<AddressCreateModel> HomeAddresses { get; set; }

        public ICollection<AddressCreateModel> OfficeAddresses { get; set; }
    }
}
