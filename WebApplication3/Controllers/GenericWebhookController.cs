using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    public class GenericWebhookController : Controller
    {
        [GenericWebHook(Id = "teleported")]
        public async Task<IActionResult> Teleported(string @event, object data)
        {
            ///do something with the data
            return Ok();
        }

        // GET: GenericWebhookController
        public ActionResult Index()
        {
            return View();
        }

        // GET: GenericWebhookController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GenericWebhookController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GenericWebhookController/Create
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

        // GET: GenericWebhookController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GenericWebhookController/Edit/5
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

        // GET: GenericWebhookController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GenericWebhookController/Delete/5
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
