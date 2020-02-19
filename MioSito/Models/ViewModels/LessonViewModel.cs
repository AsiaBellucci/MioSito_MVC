using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MioSito.Models.ViewModels
{
    public class LessonViewModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int CourseId { get; set; }
        [Required]
        public string LessonNum { get; set; }
        public string Description { get; set; }
        [Required]
        public string Duration { get; set; }
    }
}
