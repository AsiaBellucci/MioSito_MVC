using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MioSito.Models.ViewModels
{
    public class AppleViewModel
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public int Weight { get; set; }
        public string Variety { get; set; }
        public string Origin { get; set; }

        //internal static void FromListToView(double weight)/*string color, double weight, string variety, string origin*/
        //{
        //    AppleViewModel caratteristiche = new AppleViewModel()
        //    {
        //        Weight = weight,
        //        Color = color,
        //        Variety = variety,
        //        Origin = origin
        //    };
        //}
    }
}
