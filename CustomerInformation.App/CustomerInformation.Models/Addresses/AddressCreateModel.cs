using System.Collections.Generic;

namespace CustomerInformation.Models.Addresses
{
    public class AddressCreateModel
    {
        public string Address { get; set; }

        public ICollection<string> PhoneNumbers { get; set; }
    }
}
