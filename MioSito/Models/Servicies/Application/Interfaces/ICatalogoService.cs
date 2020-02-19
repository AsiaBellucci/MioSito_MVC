using MioSito.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MioSito.Models.Servicies.Application.Interfaces
{
    public interface ICatalogoService
    {
        //public List<CatalogoViewModel> GetCatalogoAsync();
        //public CatalogoViewModel GetDettaglioAsync(string Id);
        //public bool InsertDettaglio(AddCourseViweModel corso);

        public  Task<List<CatalogoViewModel>> GetCatalogoAsync();
        public Task<CatalogoViewModel> GetDettaglioAsync(string Id);
        public bool InsertDettaglio(AddCourseViweModel corso);
    }
}
