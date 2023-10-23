using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Admin.Controllers
{
    public class AdmindataController : Controller
    {
        // GET: AdmindataController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AdmindataController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdmindataController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdmindataController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdmindataController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdmindataController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdmindataController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdmindataController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
