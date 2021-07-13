using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace siteMain.Domain.Entities
{
    public class Films:EntityBase
    {
        [Required(ErrorMessage = "Заполните название фильма")]
        [Display(Name = "Название фильма")]
        [MaxLength(150)]
        public override string Title { get; set; }

        [Display(Name = "Полное описание фильма")]
        public override string Text { get; set; }

        [Display(Name = "Средний рейтинг фильма")]
        public float AvgRateFilm { get; set; }

        public List<UserRatesFilm> UserRatesFilms { get; set; }
        public List<FilmsAndActors> FilmsAndActors { get; set; }
    }
    
}
