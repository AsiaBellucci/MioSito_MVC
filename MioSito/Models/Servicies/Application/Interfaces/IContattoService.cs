using MioSito.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MioSito.Models.Servicies.Application.Interfaces
{
    public interface IContattoService
    {
        public ContattoViewModel GetContatto();
    }
}
