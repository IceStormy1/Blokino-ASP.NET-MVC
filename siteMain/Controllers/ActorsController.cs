using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using siteMain.Domain;

namespace siteMain.Controllers
{
    public class ActorsController : Controller
    {
        private readonly DataManager dataManager;
        private readonly AppDbContext context;
        UserManager<IdentityUser> _manager;

        // private readonly IWebHostEnvironment hostingEnvironment;
        public ActorsController(DataManager dataManager, UserManager<IdentityUser> manager)
        {
            this.dataManager = dataManager;
            this._manager = manager;

        }

        public IActionResult Index(Guid id)
        {
            if (id != default)
            {
                return View("ShowActor", dataManager.Actors.GetActorsById(id));
            }

             ViewBag.TextField = dataManager.TextFields.GetTextFieldsByCodeWord("PageServices");
            return View(dataManager.Actors.GetActors());
        }
    }
}
