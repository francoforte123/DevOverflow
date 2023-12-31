﻿using DevOverflow.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevOverflow.Controllers
{
    public class ResponseController : Controller
    {
        // GET: ResponseController
        public ActionResult Index()
        {
            return View(new List<Response>()
            {
                new Response
                {
                    Id = 1,
                    Author= "Steven Spielberg",
                    Description= "Lo Squalo, Jurassic Park, Prova a prendermi, Schinder's list, Salvate il soldato Ryan, Ritorno al futuro, Indiana Jones",
                    IsAccepted=""                    
                },

                new Response
                {
                    Id = 2,
                    Author= "James Cameron",
                    Description= "Titanic, Avatar, Terminator, Rambo 2, Sanctum 3D, Solaris",
                    IsAccepted=""                    
                }
            });
        }

        // GET: ResponseController/Details/5
        public ActionResult Details(int id)
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
