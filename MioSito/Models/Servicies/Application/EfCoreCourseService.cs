using MioSito.Models.Servicies.Application.Interfaces;
using MioSito.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MioSito.Models.Servicies.Application
{
    public class EfCoreCourseService : ICatalogoService
    {
        public Task<List<CatalogoViewModel>> GetCatalogoAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CatalogoViewModel> GetDettaglioAsync(string Id)
        {
            throw new NotImplementedException();
        }

        public bool InsertDettaglio(AddCourseViweModel corso)
        {
            throw new NotImplementedException();
        }
    }
}
