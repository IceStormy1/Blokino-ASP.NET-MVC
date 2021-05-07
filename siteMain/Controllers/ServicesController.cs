using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using siteMain.Domain;
using siteMain.Domain.Entities;
using siteMain.Domain.Repositories.EntityFramework;

namespace siteMain.Controllers
{
    [Authorize]
    public class ServicesController : Controller
    {
        private readonly DataManager dataManager;

        public ServicesController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        
        public IActionResult Index(Guid id)
        {
            UserRate userRate = new UserRate();
            ViewBag.IdFilm = userRate.IdFilm;
            ViewBag.RateFilm = userRate.RateFilm;
            ViewBag.IdUser = userRate.IdUser;
            ViewBag.UserName = userRate.UserName;
            
            if (id != default)
            {
                return View("Show", dataManager.ServiceItems.GetServiceItemById(id));
            }

            ViewBag.TextField = dataManager.TextFields.GetTextFieldsByCodeWord("PageServices");
            return View(dataManager.ServiceItems.GetServiceItems());
        }
    }
}
