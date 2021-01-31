using CustomerInformation.App.CustomerService;
using System.Web.Http;

namespace CustomerInformation.App.Controllers
{
    public class CustomerController : ApiController
    {
        [Route("api/Customer/Create")]
        public bool Create(CustomerCreateModel model)
        {
            var customerService = new CustomerServiceClient();
            var result = customerService.Create(model);

            return result;
        }

        [Route("api/Customer/Update")]
        public bool Update(CustomerUpdateModel model)
        {
            var customerService = new CustomerServiceClient();
            var result = customerService.Update(model);
            return result;
        }

        [Route("api/Customer/Delete")]
        [HttpPost]
        public bool Delete(DeleteByIdModel model)
        {
            var customerService = new CustomerServiceClient();
            var result = customerService.DeleteById(model);
            return result;
        }

    }
}