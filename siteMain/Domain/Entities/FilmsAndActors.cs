using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace siteMain.Domain.Entities
{
    public class FilmsAndActors
    {
        [Key]
        public int IdNumber { get; set; }

        [Required]
        public Guid IdFilm { get; set; }

        public string Title { get; set; }

        [Required]
        public Guid IdActor { get; set; }

        public string NameActor { get; set; }


        [ForeignKey("IdFilm")]
        public ServiceItem ServiceItem { get; set; }

        [ForeignKey("IdActor")]
        public Actors Actors { get; set; }
    }
}
