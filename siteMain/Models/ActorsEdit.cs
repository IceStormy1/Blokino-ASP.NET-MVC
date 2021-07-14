using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace siteMain.Models
{
    public class ActorsEdit
    {
        [Required(ErrorMessage = "Заполните имя актера")]
        [Display(Name = "Имя актера")]
        public string Title { get; set; }

        [Display(Name = "Краткая биография актера")]
        public string Subtitle { get; set; }

        [Display(Name = "Полная биография актера")]
        public string Text { get; set; }

        [Display(Name = "Средний рейтинг актера")]
        public float AvgRateActor { get; set; }

        public string UsersId { get; set; }

        public List<FilmsAndActorsModel> FilmsAndActors { get; set; }

        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Титульная картинка")]
        public virtual string TitleImagePath { get; set; }

        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }

        public bool GetUserById { get; set; }

        public int UsersMark { get; set; }
    }
}