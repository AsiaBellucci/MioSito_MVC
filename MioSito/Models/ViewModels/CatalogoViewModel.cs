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
        public string Price { get; set; }
        public string ImagePath { get; set; }

        internal static CatalogoViewModel FromDbToView(DataRow rigaCorso)
        {
            CatalogoViewModel catalogoCorso = new CatalogoViewModel
            {
                Id = Convert.ToInt32(rigaCorso["Id"]),
                Title = Convert.ToString(rigaCorso["Title"]),
                Price = Convert.ToString(rigaCorso["FullPrice_Amount"]),
                ImagePath = Convert.ToString(rigaCorso["ImagePath"])
            };
            return catalogoCorso;
        }
    }
}
