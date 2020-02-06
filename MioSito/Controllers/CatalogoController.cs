using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MioSito.Models;
using MioSito.Models.Servicies.Application.Interfaces;
using MioSito.Models.ViewModels;

namespace MioSito.Controllers
{
    public class CatalogoController : Controller
    {
        private readonly ICatalogoService _catalogo;

        public CatalogoController(ICatalogoService catalogo)
        {
            this._catalogo = catalogo;
        }
        // GET: Catalogo
        public ActionResult Index()
        {
            #region Vecchio codice
            Catalogo c = new Catalogo()
            {
                Immagine = "immag",
                Prodotto = "prod1",
                Prezzo = "543",
                Dettaglio = 2
            };
            List<Catalogo> lista = new List<Catalogo>();
            lista.Add(c);
            #endregion
            // CatalogoViewModel catalogo = _catalogo.GetCatalogo(); 
            return View(c);
        }

        // GET: Catalogo/Details/5
        public ActionResult Dettagli(/*Dettagli dett*/)
        {
            return View(/*dett*/);
        }

        // GET: Catalogo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Catalogo/Create
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

        // GET: Catalogo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Catalogo/Edit/5
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

        // GET: Catalogo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Catalogo/Delete/5
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