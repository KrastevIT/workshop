using CustomerInformation.Models.Phones;
using System.ServiceModel;

[ServiceContract]
public interface IPhoneService
{
    [OperationContract]
    PhoneNumberByIdModel GetHomePhoneNumberById(int id);

    [OperationContract]
    PhoneNumberByIdModel GetOfficePhoneNumberById(int id);
}
