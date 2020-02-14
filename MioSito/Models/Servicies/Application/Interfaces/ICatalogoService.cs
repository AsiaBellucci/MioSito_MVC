using MioSito.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MioSito.Models.Servicies.Application.Interfaces
{
    public interface ICatalogoService
    {
        public List<CatalogoViewModel> GetCatalogo();
        public CatalogoViewModel GetDettaglio(string Id);
        public bool InsertDettaglio(AddCourseViweModel corso);
    }
}
