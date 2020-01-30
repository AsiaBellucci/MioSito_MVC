using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MioSito.Models;

namespace MioSito.Controllers
{
    public class ContattiController : Controller
    {

        // GET: Contatti
        public ActionResult Index()
        {
            Contatto c = new Contatto();
            
            return View(c);
        }

        // GET: Contatti/Details/5
        public ActionResult Report()
        {
            return View();
        }

        // GET: Contatti/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contatti/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Contatti/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Contatti/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Contatti/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Contatti/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        
    }
}