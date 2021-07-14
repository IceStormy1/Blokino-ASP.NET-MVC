using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using siteMain.Domain.Entities;

namespace siteMain.Areas.Admin.Model
{
    [Area("Admin")]
    public class FilmsAndActorsAdmin
    {
        public IQueryable<Films> Films { get; set; }
        public IQueryable<Actors> Actors { get; set; }
    }
}
