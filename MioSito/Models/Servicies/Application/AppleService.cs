using MioSito.Models.Servicies.Application.Interfaces;
using MioSito.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MioSito.Models.Servicies.Application
{
    public class AppleService : IProductService
    {
        List<AppleViewModel> apples = new List<AppleViewModel> {
            new AppleViewModel { Color = "Red", Weight = 180, Variety = "Stark Delicious", Origin = "Italy"},
            new AppleViewModel { Color = "Green", Weight = 195, Variety = "Granny Smith", Origin = "Spain" },
            new AppleViewModel { Color = "Red", Weight = 190, Variety = "Stark Delicious", Origin = "France" },
            new AppleViewModel { Color = "Green", Weight = 185, Variety = "Granny Smith", Origin = "Italy" },
            new AppleViewModel { Color ="Yellow", Weight = 190, Variety = "Golden Delicious", Origin = "Spain"},
            new AppleViewModel { Color ="Yellow", Weight = 175, Variety = "Golden Delicious", Origin = "France"},
            new AppleViewModel { Color ="Red", Weight = 190, Variety = "Stark Delicious", Origin = "Italy" }
            };
        public int GetAppleMin()
        {
            int min = apples.Select(apple => apple.Weight).Min();
            return min;
        }

        public ProductViewModel GetProduct()
        {
            ProductViewModel product = new ProductViewModel(GetAppleMin());
            return product;
        }

        public IEnumerable<AppleViewModel> getRedApples()
        {
            IEnumerable<AppleViewModel> takeRedApples = apples.Where(apple => apple.Color == "Red");
            

            return takeRedApples;
        }


    }
}
