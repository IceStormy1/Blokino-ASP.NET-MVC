using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using siteMain.Service;

namespace siteMain.Domain.Entities
{
    public class Actors:EntityBase
    {
        [Required(ErrorMessage = "Заполните имя актера")]
        [Display(Name = "Имя актера")]
        public override string Title { get; set; }


        [Display(Name = "Краткая биография актера")]
        public override string Subtitle { get; set; }

        [Display(Name = "Полная биография актера")]
        public override string Text { get; set; }

        [Display(Name = "Средний рейтинг актера")]
        public float AvgRateActor { get; set; }

        public List<FilmsAndActors> FilmsAndActors { get; set; }
    }
}