using Microsoft.AspNetCore.Mvc;

namespace Admin.Controllers
{
    [Route("api/Message")]
    [ApiController]
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        



    }


}
