﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MioSito.Models
{
    public class Catalogo
    {
        
        public string Immagine { get; set; } = "image";
        public string Prodotto { get; set; } = "web marketing";
        public string Prezzo { get; set; } = "€ bh";

        
        //public List<Catalogo> AddValueToList(Catalogo c, List<Catalogo> listaC)
        //{
            
        //    listaC.Add(c);
        //    return listaC;
        //}


    }
    
    public class ListCatalogo
    {
        public List<Catalogo> ListaC { get; set; }
    }
}
