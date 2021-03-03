using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCIntroNa21.Models.ViewModels
{
    public class IndexViewModel
    {
        [Required]
        [Display(Name = "Förnamn")]
        [StringLength(30, ErrorMessage = "Max 30 tecken")]
        public string Name { get; set; }

        public string Department { get; set; }
    }
}
