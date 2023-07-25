using DevOverflow.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevOverflow.Controllers
{
    public class RequestController : Controller
    {
        // GET: ResponseController
        public ActionResult Index()
        {
            return View(new List<Request>()
            {
                new Request
                {
                    Id = 0,
                    Author= "Steven Spielberg",
                    Title= "Write some movies turn around of Steven Spielberg",
                    Description= ""
                },

                new Request
                {
                    Id = 1,
                    Author= "James Cameron",
                    Title= "Write some movies turn around of James Cameron",
                    Description= ""
                }
            });
        }

        // GET: ResponseController/Details/5
        public ActionResult Details()
        {
            return View();
        }

        // GET: ResponseController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ResponseController/Create
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

        // GET: ResponseController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ResponseController/Edit/5
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

        // GET: ResponseController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ResponseController/Delete/5
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
