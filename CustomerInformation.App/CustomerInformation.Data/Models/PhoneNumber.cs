namespace CustomerInformation.Data.Models
{
    public class PhoneNumber
    {
        public int Id { get; set; }

        public string Phone { get; set; }

        public int AddressId { get; set; }

        public Address Address { get; set; }
    }
}
