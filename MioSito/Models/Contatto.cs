﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MioSito.Models
{
    public class Contatto
    {
        public string Nome { get; set; } = ""; 
        public string Cognome { get; set; } = "";
        public string Indirizzo { get; set; } = "";
        public string Città { get; set; } = "";
        public string Telefono { get; set; } = "";
        public string Immagine { get; set; } = "~/images/ImagineDragons.jpg";

        
    }
}
