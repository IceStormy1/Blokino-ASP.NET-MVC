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
    public class RateUser
    {
        [Key]
        public int IdNumber { get; set; }

        public string UsersId { get; set; }

        public string UserName { get; set; }

        [Required]
        public Guid IdFilm { get; set; }

        public string Title { get; set; }

        public int RateFilm { get; set; }
    }
}