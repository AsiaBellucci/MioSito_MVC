using MioSito.Models.Servicies.Application.Interfaces;
using MioSito.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MioSito.Models.Servicies.Application
{
    public class CatalogoService : ICatalogoService
    {
        private readonly IDatabaseConnector db;
        public CatalogoService(IDatabaseConnector dbConnector)
        {
            this.db = dbConnector;
        }

        public List<CatalogoViewModel> GetCatalogo()
        {
            #region Codice senza db
            //CatalogoViewModel catalogo = new CatalogoViewModel()
            //{
            //    Immagine = "immag",
            //    Prodotto = "prod1",
            //    Prezzo = "543",
            //    IdDettaglio = 2
            //};
            //List<CatalogoViewModel> lista = new List<CatalogoViewModel>();
            //lista.Add(catalogo);
            //return lista;
            #endregion

            string query = "SELECT Id, Title, FullPrice_Amount, ImagePath FROM Courses";
            DataSet dataSet = db.Query(query);
            DataTable dataTable = dataSet.Tables[0];
            List<CatalogoViewModel> lista = new List<CatalogoViewModel>();
            foreach (DataRow RigaCorso in dataTable.Rows)
            {
                CatalogoViewModel viewModel = CatalogoViewModel.FromDbToView(RigaCorso);
                lista.Add(viewModel);
            }
            return lista;
        }
    }
}
