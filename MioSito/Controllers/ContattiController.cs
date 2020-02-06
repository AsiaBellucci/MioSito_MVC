using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MioSito.Models;
using MioSito.Models.Servicies.Application;
using MioSito.Models.Servicies.Application.Interfaces;
using MioSito.Models.ViewModels;

namespace MioSito.Controllers
{
    public class ContattiController : Controller
    {
        private readonly IContattoService _contatto;

        public ContattiController(IContattoService contatto)
        {
            this._contatto = contatto;
        }

        // GET: Contatti
        public ActionResult Index()
        {
            ContattoViewModel contatto = _contatto.GetContatto();
            return View(contatto);
        }

        // GET: Contatti/Report/5
        public ActionResult Report(Report risp)
        {
            return View(risp);
        }

        public ActionResult PassaggioDati(Report dati)
        {
            return View(dati);
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