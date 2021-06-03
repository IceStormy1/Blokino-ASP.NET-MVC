using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using siteMain.Service;

namespace siteMain.Domain.Entities
{
    public class UserRatesActors
    {
        [Key]
        public int IdNumber { get; set; }

        public string UsersId { get; set; }

        public string UserName { get; set; }

        [Required]
        public Guid IdActor { get; set; }

        public string Title { get; set; }

        public int RateActor { get; set; }

        public User Users { get; set; }

        [ForeignKey("IdActor")]
        public Actors Actors { get; set; }
    }
}
