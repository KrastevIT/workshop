using CustomerInformation.Models.Customers;
using System.Collections.Generic;
using System.ServiceModel;

[ServiceContract]
public interface ICustomerService
{
    [OperationContract]
    bool Create(CustomerCreateModel model);

    [OperationContract]
    bool Update(CustomerUpdateModel model);

    [OperationContract]
    bool DeleteById(DeleteByIdModel model);

    [OperationContract]
    ICollection<GetAllDataModel> GetAllData();

    [OperationContract]
    CustomerByIdModel GetCustomerById(int id);
}
