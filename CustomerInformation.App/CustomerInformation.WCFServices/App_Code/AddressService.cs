using CustomerInformation.Data;
using CustomerInformation.Models.Addresses;
using System.Linq;

public class AddressService : IAddressService
{
    public AddressByIdModel GetHomeAddressById(int id)
    {
        var db = new CustomerInformationContext();

        var address = db.HomeAddresses.FirstOrDefault(x => x.Id == id);

        var model = new AddressByIdModel
        {
            Id = id,
            Number = address.Address
        };

        return model;
    }
}
