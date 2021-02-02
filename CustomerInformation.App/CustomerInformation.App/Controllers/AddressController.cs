using CustomerInformation.App.AddressService;
using System.Web.Http;

namespace CustomerInformation.App.Controllers
{
    public class AddressController : ApiController
    {
        [Route("api/Address/GetHomeAddressById/{id}")]
        public AddressByIdModel GetHomeAddressById(int id)
        {
            var addressService = new AddressServiceClient();
            var model = addressService.GetHomeAddressById(id);
            return model;
        }
    }
}