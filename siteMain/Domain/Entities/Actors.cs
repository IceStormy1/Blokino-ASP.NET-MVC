using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace siteMain.Domain.Entities
{
    public class Actors:EntityBase
    {
        [Required(ErrorMessage = "Заполните имя актера")]
        [Display(Name = "Имя актера")]
        [MaxLength(250)]
        public override string Title { get; set; }

        [Required]
        [Display(Name = "Полная биография актера")]
        public override string Text { get; set; }

        [Display(Name = "Средний рейтинг актера")]
        public float AvgRateActor { get; set; }

        public List<FilmsAndActors> FilmsAndActors { get; set; }
    }
}