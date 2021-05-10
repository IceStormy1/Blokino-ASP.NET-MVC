using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using siteMain.Areas.Admin.Controllers;
using siteMain.Domain;
using siteMain.Domain.Entities;
using siteMain.Domain.Repositories.EntityFramework;
using siteMain.Models;
using siteMain.Service;

namespace siteMain.Controllers
{
    [Authorize]
    public class ServicesController : Controller
    {
        private readonly DataManager dataManager;
       // private readonly IWebHostEnvironment hostingEnvironment;
        public ServicesController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        
        public IActionResult Index(Guid id)
        {
            //UserRate userRate = new UserRate();
            //ViewBag.IdFilm = userRate.IdFilm;
            //ViewBag.RateFilm = userRate.RateFilm;
            //ViewBag.IdUser = userRate.IdUser;
            //ViewBag.UserName = userRate.UserName;
            
            if (id != default)
            {
                return View("Show", dataManager.ServiceItems.GetServiceItemById(id));
            }

            ViewBag.TextField = dataManager.TextFields.GetTextFieldsByCodeWord("PageServices");
            return View(dataManager.ServiceItems.GetServiceItems());
        }
        [HttpPost]
        public IActionResult Mark(Mark mark, UserRate model)
        {
            //var markValue = mark.MarkValue;
            model.RateFilm = mark.MarkValue;
            dataManager.UserRate.SaveUserRate(model);
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }

    }
}
