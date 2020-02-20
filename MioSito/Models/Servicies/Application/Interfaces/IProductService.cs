using MioSito.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MioSito.Models.Servicies.Application.Interfaces
{
    public interface IProductService
    {
        public int GetAppleMin();
        public IEnumerable<AppleViewModel> getRedApples();
        public ProductViewModel GetProduct();
    }
}
