using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using siteMain.Service;

namespace siteMain.Domain.Entities
{
    public class UserRatesFilm
    {
        [Key]
        public int IdNumber { get; set; }

        public string UsersId { get; set; }

        [Required]
        public Guid IdFilm { get; set; }

        public int RateFilm { get; set; }

        public User Users { get; set; }
       
        [ForeignKey("IdFilm")]
        public Films Films { get; set; }
    }
}
