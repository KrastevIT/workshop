namespace CustomerInformation.Data.Models
{
    public class OfficePhone
    {
        public int Id { get; set; }

        public string Number { get; set; }

        public int OfficeAddressId { get; set; }

        public OfficeAddress OfficeAddress { get; set; }
    }
}
