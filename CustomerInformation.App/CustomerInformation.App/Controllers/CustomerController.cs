using CustomerInformation.App.CustomerService;
using System.Web.Http;

namespace CustomerInformation.App.Controllers
{
    public class CustomerController : ApiController
    {
        public bool Create(CustomerCreateModel model)
        {
            var customerService = new CustomerServiceClient();
            var result = customerService.Create(model);
            return result;
        }
    }
}