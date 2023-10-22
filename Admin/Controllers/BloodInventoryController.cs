using Microsoft.AspNetCore.Mvc;

namespace Admin.Controllers
{
    public class BloodInventoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }

}
