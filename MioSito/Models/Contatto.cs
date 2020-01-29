using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MioSito.Models
{
    public class Contatto
    {
        public string Nome { get; set; } = "Giuseppe"; 
        public string Cognome { get; set; } = "Baldoni";
        public string Indirizzo { get; set; } = "via byhv";
        public string Città { get; set; } = "baban";
        public int Telefono { get; set; } = 125463;
        public string Immagine { get; set; } = "~/images/ImagineDragons.jpg";

        
    }
}
