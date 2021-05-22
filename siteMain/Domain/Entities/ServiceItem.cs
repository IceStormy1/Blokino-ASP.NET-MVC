using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using siteMain.Domain.Entities;


namespace siteMain.Domain.Entities
{
    public class ServiceItem:EntityBase
    {
        [Required(ErrorMessage = "Заполните название фильма")]
        [Display(Name = "Название фильма")]
        public override string Title { get; set; }


        [Display(Name = "Краткое описание фильма")]
        public override string Subtitle { get; set; }

        [Display(Name = "Полное описание фильма")]
        public override string Text { get; set; }

        [Display(Name = "Средний рейтинг фильма")]
        public float AvgRateFilm { get; set; }

        public List<UserRates> UserRates { get; set; }
        public List<FilmsAndActors> FilmsAndActors { get; set; }
    }
    
}
