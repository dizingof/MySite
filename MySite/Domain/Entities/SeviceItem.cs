using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MySite.Domain.Entities
{
    public class SeviceItem: EntityBase
    {
        [Required(ErrorMessage ="Zapolnite nazvanie uslugi")]
        [Display(Name = "Nazvanie uslugi")]
        public override string Title { get; set; } 


        [Display(Name = "Kratkoe opisanie uslugi")]
        public override string Subtitle { get; set; }

        [Display(Name = "Polnoe opisanie uslugi")]
        public override string Text { get; set; } 
      
    }
}
