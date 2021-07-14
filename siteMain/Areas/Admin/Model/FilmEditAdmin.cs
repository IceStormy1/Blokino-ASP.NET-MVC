using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using siteMain.Domain.Entities;

namespace siteMain.Areas.Admin.Model
{
    public class FilmEditAdmin
    {
       // public FilmEditAdmin() => DateAdded = DateTime.UtcNow;

        [Required(ErrorMessage = "Заполните название фильма")]
        [Display(Name = "Название фильма")]
        [MaxLength(150)]
        public string Title { get; set; }

        [Display(Name = "Полное описание фильма")]
        public string Text { get; set; }

        [Display(Name = "Средний рейтинг фильма")]
        public float AvgRateFilm { get; set; }

        public List<UserRatesFilm> UserRatesFilms { get; set; }
        public List<FilmsAndActors> FilmsAndActors { get; set; }


    }
}
