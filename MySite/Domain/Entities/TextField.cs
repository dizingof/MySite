using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MySite.Domain.Entities
{
    public class TextField :EntityBase
    {
        [Required]
        public string CodeWord { get; set; }
        [Display(Name = "Nazvanie (zagolovok)")]
        public override string Title { get; set; } = "Informacionnaya stranica";
        [Display(Name = "Soderganie stranici")]
        public override string Text { get; set; } = "Soderganie zapolnyaetsya administratorom";
    }
}
