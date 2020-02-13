using Store.Models.Enums;
using Store.Models.ValueTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MioSito.Models.ViewModels
{
    public class CatalogoViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public Money FullPrice { get; set; }
        public string Valuta { get; set; }
        public string ValutaCor { get; set; }
        public Money CurrentPrice { get; set; }

        internal static CatalogoViewModel FromDbToView(DataRow rigaCorso)
        {
            CatalogoViewModel catalogoCorso = new CatalogoViewModel
            {
                Id = Convert.ToInt32(rigaCorso["Id"]),
                Title = Convert.ToString(rigaCorso["Title"]),
                //Price = Convert.ToString(rigaCorso["FullPrice_Amount"]),
                FullPrice = new Money(Enum.Parse<Currency>(Convert.ToString(rigaCorso["FullPrice_Currency"])),
                            Convert.ToDecimal(rigaCorso["FullPrice_Amount"])),
                CurrentPrice = new Money(Enum.Parse<Currency>(Convert.ToString(rigaCorso["CurrentPrice_Currency"])),
                            Convert.ToDecimal(rigaCorso["CurrentPrice_Amount"])),
                ImagePath = Convert.ToString(rigaCorso["ImagePath"])
            };
            return catalogoCorso;
        }
        
    }
}
