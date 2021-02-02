using CustomerInformation.Models.Addresses;
using System.ServiceModel;

[ServiceContract]
public interface IAddressService
{
    [OperationContract]
    AddressByIdModel GetHomeAddressById(int id);
}
