using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace siteMain.Domain.Entities
{
    public class FilmsAndActors
    {
        [Key]
        public int IdNumber { get; set; }

        [Required]
        public Guid IdFilm { get; set; }

        [Required]
        public Guid IdActor { get; set; }

        [ForeignKey("IdFilm")]
        public Films Films { get; set; }

        [ForeignKey("IdActor")]
        public Actors Actors { get; set; }
    }
}
