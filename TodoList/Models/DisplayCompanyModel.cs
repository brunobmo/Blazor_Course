using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace TodoList.Models
{
    public class DisplayCompanyModel
    {
        [Required]
        [StringLength(15, ErrorMessage = "Company Name is too long.")]
        [MinLength(3, ErrorMessage = "Company Name is too short.")]
        public string CompanyName { get; set; }

        [Required]
        [StringLength(9, ErrorMessage = " NIF is too long.")]
        [MinLength(9, ErrorMessage = "NIF is too short.")]
        public string NIF { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
    }
}