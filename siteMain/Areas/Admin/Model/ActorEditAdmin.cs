using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using siteMain.Domain.Entities;

namespace siteMain.Areas.Admin.Model
{
    public class ActorEditAdmin
    {
        public ActorEditAdmin() => DateAdded = DateTime.UtcNow;

        [Required]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Заполните имя актера")]
        [Display(Name = "Имя актера")]
        [MaxLength(250)]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Полная биография актера")]
        public string Text { get; set; }

        [Display(Name = "Средний рейтинг актера")]
        public float AvgRateActor { get; set; }

        [Display(Name = "Титульная картинка")]
        public virtual string TitleImagePath { get; set; }

        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }

        public IQueryable<Films> GetFilms { get; set; }

        public List<FilmsAndActors> FilmsAndActors { get; set; }
    }
}
