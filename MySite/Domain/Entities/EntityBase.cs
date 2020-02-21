using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MySite.Domain.Entities
{
    public abstract class EntityBase
    {
        protected EntityBase() => DateAdded = DateTime.UtcNow;
        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Nazvanie (zagolovok)")]
        public virtual string Title { get; set; }
        [Display(Name = "Kratkoe opisanie")]
        public virtual string Subtitle { get; set; }
        [Display(Name = "Polnoe opisanie")]
        public virtual string Text { get; set; }
        [Display(Name = "Titulnaya kartinka")]
        public virtual string TitleImagePath { get; set; }
        [Display(Name = "SEO metateg Title")]
        public  string MetaTitle { get; set; }

        [Display(Name = "SEO metateg Description")]
        public  string MetaDescription { get; set; }

        [Display(Name = "SEO metateg Keywords")]
        public  string MetaKeywords { get; set; }

        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }
    }
}
