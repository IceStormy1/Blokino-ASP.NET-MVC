using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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

        [Display(Name = "Рейтинг фильма")]
        public override int movieRating { get; set; }

    }
}
