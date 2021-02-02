using CustomerInformation.Data;
using CustomerInformation.Models.Phones;
using System.Linq;

public class PhoneService : IPhoneService
{
    public PhoneNumberByIdModel GetHomePhoneNumberById(int id)
    {
        var db = new CustomerInformationContext();

        var phone = db.HomePhones.FirstOrDefault(x => x.Id == id);

        var model = new PhoneNumberByIdModel
        {
            Id = id,
            Number = phone.Number
        };

        return model;
    }

    public PhoneNumberByIdModel GetOfficePhoneNumberById(int id)
    {
        var db = new CustomerInformationContext();

        var phone = db.OfficePhones.FirstOrDefault(x => x.Id == id);

        var model = new PhoneNumberByIdModel
        {
            Id = id,
            Number = phone.Number
        };

        return model;
    }
}
