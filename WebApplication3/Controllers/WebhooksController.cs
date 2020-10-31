﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebHooks;

namespace WebApplication3.Controllers
{
    public class WebhooksController : Controller
    {
        [GeneralWebHookAttribute(Id = "teleported")]
        public async Task<IActionResult> Teleported(string @event, object data)
        {
            ///do something with the data
            return Ok();
        }

        // GET: WebhooksController
        public ActionResult Index()
        {
            return View();
        }

        // GET: WebhooksController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: WebhooksController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WebhooksController/Create
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

        // GET: WebhooksController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: WebhooksController/Edit/5
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

        // GET: WebhooksController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: WebhooksController/Delete/5
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
