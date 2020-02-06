using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MioSito.Models.ViewModels
{
    public class CatalogoViewModel
    {
        public string Immagine { get; set; }
        public string Prodotto { get; set; }
        public string Prezzo { get; set; }
        public int IdDettaglio { get; set; }
    }
}
