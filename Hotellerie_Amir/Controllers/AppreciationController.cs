using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hotellerie_Amir.Controllers
{
    public class AppreciationController : Controller
    {
        // GET: AppreciationController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AppreciationController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AppreciationController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AppreciationController/Create
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

        // GET: AppreciationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AppreciationController/Edit/5
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

        // GET: AppreciationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AppreciationController/Delete/5
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
