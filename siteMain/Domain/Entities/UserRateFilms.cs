using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace siteMain.Domain.Entities
{
    public class UserRateFilms:EntityBase
    {
        [Display(Name = "ID пользователя")]
        public string IdUser { get; set; }

        [Display(Name = "ID фильма")]
        public string IdFilms { get; set; }

        [Display(Name = "Название фильма")]
        public override string Title { get; set; }

        [Display(Name = "Оценка пользователя")]
        public override int MovieRating { get; set; }

    }
}
