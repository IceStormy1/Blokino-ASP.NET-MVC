using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using siteMain.Domain;
using siteMain.Domain.Entities;
using siteMain.Models;
using siteMain.Service;

namespace siteMain.Controllers
{
    [Authorize]
    public class ServicesController : Controller
    {
        private readonly DataManager _dataManager;
        readonly UserManager<IdentityUser> _manager;
        
        public ServicesController(DataManager dataManager, UserManager<IdentityUser> manager)
        {
            this._dataManager = dataManager;
            this._manager = manager;
        }
        
        public IActionResult Index(Guid id, string sortOrder)
        {
            if (id != default)
            {
                var serviceItemById = _dataManager.ServiceItems.GetServiceItemById(id);

                return View("Show", new ServiceItemEdit()
                {
                    Id = serviceItemById.Id,
                    Title = serviceItemById.Title,
                    AvgRateFilm = serviceItemById.AvgRateFilm,
                    TitleImagePath = serviceItemById.TitleImagePath,
                    Text = serviceItemById.Text,
                    FilmsAndActors = serviceItemById.FilmsAndActors.Select(x=>new FilmsAndActorsModel()
                    {
                        Title = x.NameActor
                    }).ToList()
                });

            }

            ViewBag.TextField = _dataManager.TextFields.GetTextFieldsByCodeWord("PageServices");
            ViewBag.DateSortParm = sortOrder == "Avg" ? "Avg" : "avg_desc";
            var sort = _dataManager.ServiceItems.GetServiceItems();

            switch (sortOrder)
            {
                case "avg_desc":
                    sort = sort.OrderByDescending(s => s.AvgRateFilm);
                    break;
                case "Avg":
                    sort = sort.OrderBy(s => s.AvgRateFilm);
                    break;
            }
            return View(sort);
        }
        [HttpPost]
        public IActionResult Mark(Mark mark, UserRates model, Guid id)
        {
            var serviceItem = _dataManager.ServiceItems.GetServiceItemById(id);
            var avg = new AvgRateFilm(_dataManager);
            
            model.UsersId = _manager.GetUserId(User);
            model.UserName = _manager.GetUserName(User);
            model.RateFilm = mark.MarkValue;
            model.IdFilm = serviceItem.Id;
            model.Title = serviceItem.Title;
            model.RateFilm = mark.MarkValue;
           
            _dataManager.UserRate.SaveUserRate(model);
            avg.UpdateAvg(serviceItem.Id);

            return RedirectToAction(nameof(Index), nameof(ServicesController).CutController());
        }
    }
}
