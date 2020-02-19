using MioSito.Models.Enums;
using MioSito.Models.ValueTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MioSito.Models.ViewModels
{
    public class AddCourseViweModel
    {
        [Required]
        public int Id { get; set; }
        
        [Required, StringLength(30), Display(Name = "Inserisci titolo")]
        public string Title { get; set; }
        
        [StringLength(70), Display(Name = "Inserisci descrizione")]
        public string Description { get; set; }
        
        [StringLength(70), Display(Name = "Inserisci descrizione")]
        public string ImagePath { get; set; }
        
        [Required, StringLength(30), Display(Name = "Inserisci autore")]
        public string Author { get; set; }
        
        [EmailAddress, StringLength(30), Display(Name = "Inserisci E-mail")]
        public string Email { get; set; }

        [Required, Display(Name ="Inserisci rating")]
        public float Rating { get; set; }
        
        [Required, Display(Name = "Inserisci perzzo")]
        public double FullPrice { get; set; }

        [Required, Display(Name = "Inserisci valuta")]
        public string Valuta { get; set; }

        [Required, Display(Name = "Inserisci prezzo")]
        public double CurrentPrice { get; set; }

        [Required, Display(Name = "Inserisci valuta")]
        public string ValutaCor { get; set; }
    }
}
