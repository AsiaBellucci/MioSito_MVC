using MioSito.Models.Servicies.Application.Interfaces;
using MioSito.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MioSito.Models.Servicies.Application
{
    public class CatalogoService : ICatalogoService
    {
        public CatalogoService() { }

        public List<CatalogoViewModel> GetCatalogo()
        {
            CatalogoViewModel catalogo = new CatalogoViewModel()
            {
                Immagine = "immag",
                Prodotto = "prod1",
                Prezzo = "543",
                IdDettaglio = 2
            };
            List<CatalogoViewModel> lista = new List<CatalogoViewModel>();
            lista.Add(catalogo);
            return lista;
        }
    }
}
