namespace CustomerInformation.Data.Models
{
    public class HomePhone
    {
        public int Id { get; set; }

        public string Number { get; set; }

        public int HomeAddressId { get; set; }

        public HomeAddress HomeAddress { get; set; }
    }
}
