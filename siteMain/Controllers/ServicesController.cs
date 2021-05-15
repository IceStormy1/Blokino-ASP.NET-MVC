using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Identity;
using siteMain.Areas.Admin.Controllers;
using siteMain.Domain;
using siteMain.Domain.Entities;
using siteMain.Domain.Repositories.EntityFramework;
using siteMain.Models;
using siteMain.Service;
using System.Web;
using Microsoft.AspNetCore.Mvc.TagHelpers;

namespace siteMain.Controllers
{
    [Authorize]
    public class ServicesController : Controller
    {
        private readonly DataManager dataManager;
        private readonly AppDbContext context;
        UserManager<IdentityUser> _manager;
        
        // private readonly IWebHostEnvironment hostingEnvironment;
        public ServicesController(DataManager dataManager, UserManager<IdentityUser> manager)
        {
            this.dataManager = dataManager;
            this._manager = manager;
            
        }
        
        public IActionResult Index(Guid id)
        {
            if (id != default)
            {
                return View("Show", dataManager.ServiceItems.GetServiceItemById(id));
            }

            ViewBag.TextField = dataManager.TextFields.GetTextFieldsByCodeWord("PageServices");
            return View(dataManager.ServiceItems.GetServiceItems());
        }
        [HttpPost]
        public IActionResult Mark(Mark mark, UserRates model, Guid id)
        {

            var serviceItem = dataManager.ServiceItems.GetServiceItemById(id);
            var avg = new AVGRateFilm(dataManager);
            
            model.UsersId = _manager.GetUserId(User).ToString();
            model.UserName = _manager.GetUserName(User).ToString();
            model.RateFilm = mark.MarkValue;
            model.IdFilm = serviceItem.Id;
            model.Title = serviceItem.Title;
            model.RateFilm = mark.MarkValue;
           
            dataManager.UserRate.SaveUserRate(model);
            avg.UpdateAVG(serviceItem.Id);
            return RedirectToAction(nameof(ServicesController.Index), nameof(ServicesController).CutController());
        }
        //[HttpPost]
        //public IActionResult Mark(Mark mark, RateUser model, Guid id)
        //{

        //    var serviceItem = dataManager.ServiceItems.GetServiceItemById(id);

        //    model.UsersId = _manager.GetUserId(User).ToString();
        //    model.UserName = _manager.GetUserName(User).ToString();
        //    model.RateFilm = mark.MarkValue;
        //    model.IdFilm = serviceItem.Id;
        //    model.Title = serviceItem.Title;
        //    model.RateFilm = mark.MarkValue;

        //    dataManager.RateUser.SaveUserRate(model);

        //    return RedirectToAction(nameof(HomeControllerDef.Index), nameof(HomeControllerDef).CutController());
        //   return Response.Redirect(Request.RawUrl);

        //}

    }
}
