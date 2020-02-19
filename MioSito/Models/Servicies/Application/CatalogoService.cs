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

        public async Task<List<CatalogoViewModel>> GetCatalogoAsync()
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

            string query = "SELECT Id, Title, FullPrice_Currency, FullPrice_Amount, CurrentPrice_Amount, CurrentPrice_Currency, ImagePath FROM Courses";
            DataSet dataSet = await db.QueryAsync(query);
            DataTable dataTable = dataSet.Tables[0];
            List<CatalogoViewModel> lista = new List<CatalogoViewModel>();
            foreach (DataRow RigaCorso in dataTable.Rows)
            {
                CatalogoViewModel viewModel = CatalogoViewModel.FromDbToView(RigaCorso);
                lista.Add(viewModel);
            }
            return lista;
        }

        public async Task<CatalogoViewModel> GetDettaglioAsync(string Id)
        {
            string query = $"SELECT Id, Title, ImagePath, FullPrice_Currency, FullPrice_Amount, CurrentPrice_Amount, CurrentPrice_Currency FROM Courses WHERE Id={Id}";
            DataSet dataSet = await db.QueryAsync(query);
            DataTable dataTable = dataSet.Tables[0];
            CatalogoViewModel dettaglio = new CatalogoViewModel();
            foreach (DataRow RigaCorso in dataTable.Rows)
            {
                dettaglio = CatalogoViewModel.FromDbToView(RigaCorso);
                
            }
            return dettaglio;
        }

        public bool InsertDettaglio(AddCourseViweModel corso)
        {

            string insertquery = $"INSERT INTO Courses ( Title, Description, ImagePath, Author, Email, Rating, FullPrice_Amount, FullPrice_Currency, CurrentPrice_Amount, CurrentPrice_Currency)" +
                                $" VALUES ( @Title, @Description, @ImagePath, @Author, @Email, @Rating, @FullPrice, @Valuta, @CurrentPrice, @ValutaCor)";
            db.InsertQueryAsync(insertquery, corso);
            return true;
        }

        
    }
}
