using ContactManagementSystem26_10_17.Services.Accounts;
using ContactManagementSystem26_10_17.Services.Items;
using ContactManagementSystem26_10_17.Services.Items.Dtos;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ContactManagementSystem26_10_17.Controllers
{
    [EnableCorsAttribute("*", "*", "*", SupportsCredentials = true)]
    public class ItemController : ApiController
    {
        [HttpPost]
        public dynamic RegisterItem(ItemDto input)
        {
            return new ItemAppService().RegisterItem(input);
        }
        [HttpPost]
        public dynamic GetItemDetailsUsingRegistrationNo(GetItemDetailsUsingRegistrationNoInput input)
        {
            return new ItemAppService().GetItemDetailsUsingRegistrationNo(input);
        }
        [HttpPost]
        public dynamic GetItemDetailsUsingSerialNo(GetItemDetailsUsingSerialNoInput [] input)
        {
            return new ItemAppService().GetItemDetailsUsingSerialNo(input);
        }
        [HttpPost]
        public dynamic GetItemDetailsUsingByItemId(GetItemDetailsUsingItemIdInput [] input)
        {
            return new ItemAppService().GetItemDetailsUsingByItemId(input);
        }
        [HttpPost]
        public dynamic DeleteItemHistory(DeleteItemHistoryInput input)
        {
            return new ItemAppService().DeleteItemHistory(input);
        }
        [HttpPost]
        public dynamic CleanRegistrationNumber(DeleteItemHistoryInput input)
        {
            return new ItemAppService().CleanRegistrationNumber(input);
        }
    }


}
