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
    public class CatalogoController : Controller
    {
        private readonly ICatalogoService _catalogo;

        public CatalogoController(ICatalogoService catalogo)
        {
            this._catalogo = catalogo;
        }
        // GET: Catalogo
        public async Task<ActionResult> IndexAsync()
        {
            #region Vecchio codice
            //Catalogo c = new Catalogo()
            //{
            //    Immagine = "immag",
            //    Prodotto = "prod1",
            //    Prezzo = "543",
            //    Dettaglio = 2
            //};
            //List<Catalogo> lista = new List<Catalogo>();
            //lista.Add(c);
            #endregion
            ICatalogoService catalogo = _catalogo;
            List<CatalogoViewModel> listaCatalogo = await catalogo.GetCatalogoAsync();
            return View(listaCatalogo);
        }

        // GET: Catalogo/Details/5
        [HttpGet]
        public async Task<ActionResult> DettagliAsync(string Id)
        {
            ICatalogoService catalogo = _catalogo;
            CatalogoViewModel Dettaglio = await catalogo.GetDettaglioAsync(Id);
            return View(Dettaglio);
        }

        // GET: Catalogo/InsertCourse
        public IActionResult InsertCourse()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Save([FromForm]AddCourseViweModel corso)
        {
            if (!ModelState.IsValid)
            {
                return View("InsertCourse");
            }

            bool AddCourse = _catalogo.InsertDettaglio(corso);
            this.ModelState.Clear();
            ViewBag.PopupMessage = "request_saved";
            return View("InsertCourse");
        }

        // POST: Catalogo/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(IndexAsync));
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

                return RedirectToAction(nameof(IndexAsync));
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

                return RedirectToAction(nameof(IndexAsync));
            }
            catch
            {
                return View();
            }
        }
    }
}