using CustomerInformation.App.PhoneService;
using System.Web.Http;

namespace CustomerInformation.App.Controllers
{
    public class PhoneController : ApiController
    {
        [Route("api/Phone/GetHomePhoneNumberById/{id}")]
        public PhoneNumberByIdModel GetHomePhoneNumberById(int id)
        {
            var phoneService = new PhoneServiceClient();
            var model = phoneService.GetHomePhoneNumberById(id);
            return model;
        }

        [Route("api/Phone/GetOfficePhoneNumberById/{id}")]
        public PhoneNumberByIdModel GetOfficePhoneNumberById(int id)
        {
            var phoneService = new PhoneServiceClient();
            var model = phoneService.GetOfficePhoneNumberById(id);
            return model;
        }
    }
}