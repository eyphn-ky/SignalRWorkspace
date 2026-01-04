using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalRWorkspace.Business;
using SignalRWorkspace.Dtos;

namespace SignalRWorkspace.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private MyBusiness _myBusiness;
        public HomeController(MyBusiness myBusiness)
        {
            _myBusiness = myBusiness;
        }

        [HttpPost]
        public async Task<IActionResult> Index(MessageDto messageObject)
        {
            await _myBusiness.SendMessageAsync(messageObject.Message);
            return Ok();
        }
    }
}
