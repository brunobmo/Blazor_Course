using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace BlazorApp.Models
{
    public class DisplayPublicationModel
    {
        [Required]
        [StringLength(15, ErrorMessage = "Title is too long.")]
        [MinLength(5, ErrorMessage = "Title is too short.")]
        public string Title { get; set; }
    
        [Required]
        public int Year { get; set; }
    }
}