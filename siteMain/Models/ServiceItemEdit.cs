using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using siteMain.Domain.Entities;

namespace siteMain.Models
{
    public class ServiceItemEdit
    {
        [Required(ErrorMessage = "Заполните название фильма")]
        [Display(Name = "Название фильма")]
        public string Title { get; set; }

        [Display(Name = "Краткое описание фильма")]
        public string Subtitle { get; set; }

        [Display(Name = "Полное описание фильма")]
        public string Text { get; set; }

        [Display(Name = "Средний рейтинг фильма")]
        public float AvgRateFilm { get; set; }

        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Титульная картинка")]
        public virtual string TitleImagePath { get; set; }

        [Display(Name = "SEO метатег Title")]
        public virtual string Metatitle { get; set; }

        [Display(Name = "SEO метатег Description")]
        public virtual string MetaDescription { get; set; }

        [Display(Name = "SEO метатег KeyWords")]
        public virtual string MetaKeyWords { get; set; }

        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }

        public IEnumerable<FilmsAndActorsModel> FilmsAndActors { get; set; }
    }
}
