using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace siteMain.Models
{
    public class FilmsEdit
    {
        [Required(ErrorMessage = "Заполните название фильма")]
        [Display(Name = "Название фильма")]
        public string Title { get; set; }

        [Display(Name = "Полное описание фильма")]
        public string Text { get; set; }

        [Display(Name = "Средний рейтинг фильма")]
        public float AvgRateFilm { get; set; }

        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Титульная картинка")]
        public virtual string TitleImagePath { get; set; }

        public string UsersId { get; set; }

        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }

        public bool GetUserById { get; set; }

        public int UsersMark { get; set; }

        public IEnumerable<FilmsAndActorsModel> FilmsAndActors { get; set; }
    }
}
