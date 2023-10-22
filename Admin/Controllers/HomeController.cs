using Admin.Data;
using Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Admin.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult Dashboard2()
        {
            return View();
        }


        public IActionResult Bloodinventory()
        {
            return View();
        }

        public IActionResult Camphandel()
        {
            return View();
        }

        public IActionResult Donerdetails()
        {
            return View();
        }

        public IActionResult Approves()
        {
            return View();
        }

        public IActionResult Sendmsg()
        {
            return View();
        }

        public IActionResult Admin()
        {
            return View();
        }

        public IActionResult Userprofile()
        {
            return View();
        }

        public IActionResult BloodInventoryCRUD()
        {
            return View();
        }

        public IActionResult Adminview()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}