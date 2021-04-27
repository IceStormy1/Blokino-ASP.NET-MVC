using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace siteMain.Domain.Entities
{
    public class AllFilms:EntityBase
    {
        [Display(Name = "Название(заголовок)")]
        public override string Title { get; set; }

        [Display(Name = "Рейтинг фильма")]
        public override int MovieRating { get; set; }
    }
}
