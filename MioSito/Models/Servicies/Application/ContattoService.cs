using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MioSito.Models.Servicies.Application.Interfaces;
using MioSito.Models.ViewModels;

namespace MioSito.Models.Servicies.Application
{
    public class ContattoService : IContattoService
    {
        public ContattoService()
        {

        }
        public ContattoViewModel GetContatto()
        {
            
            ContattoViewModel contatto = new ContattoViewModel()
            {
                Nome = "aaa",
                Cognome = "bbb",
                Indirizzo = "via cihjk",
                Città = "roma",
                Telefono = "4556123",
                Immagine = "ImagineDragons.jpg"
            };
            return contatto;
        }
    }
}
