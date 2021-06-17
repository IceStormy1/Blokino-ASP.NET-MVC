using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using siteMain.Domain;
using siteMain.Domain.Entities;
using siteMain.Models;
using siteMain.Service;

namespace siteMain.Controllers
{
    public class ActorsController : Controller
    {
        private readonly DataManager dataManager;
        private readonly AppDbContext context;
        UserManager<IdentityUser> _manager;

        public ActorsController(DataManager dataManager, UserManager<IdentityUser> manager)
        {
            this.dataManager = dataManager;
            this._manager = manager;

        }

        public IActionResult Index(Guid id, string sortOrder)
        {
            if (id != default)
            {
                var actor = dataManager.Actors.GetActorsById(id);

                return View("ShowActor", new ActorsEdit
                {
                    Id = actor.Id,
                    Title = actor.Title,
                    FilmsAndActors = actor.FilmsAndActors.Select(x => new FilmsAndActorsModel
                    {
                        Title = x.ServiceItem.Title
                    }).ToList()
                });
            }

            ViewBag.TextField = dataManager.TextFields.GetTextFieldsByCodeWord("PageServices");
            ViewBag.DateSortParm = sortOrder == "Avg" ? "Avg": "avg_desc";
            var sort = dataManager.Actors.GetActors();
            
            switch (sortOrder)
            {
                case "avg_desc":
                    sort = sort.OrderByDescending(s => s.AvgRateActor);
                    break;
                case "Avg":
                    sort = sort.OrderBy(s => s.AvgRateActor);
                    break; 
                    
            }
            return View(sort);
            //return View(dataManager.Actors.GetActors());
        }
        [HttpPost]
        public IActionResult Mark(Mark mark, UserRatesActors model, Guid id)
        {
           // var serviceItem = dataManager.ServiceItems.GetServiceItemById(id);
            var actors = dataManager.Actors.GetActorsById(id);
            var avg = new AVGRateActor(dataManager);

            model.UsersId = _manager.GetUserId(User).ToString();
            model.UserName = _manager.GetUserName(User).ToString();
            model.RateActor = mark.MarkValue;
            model.IdActor = actors.Id;
            model.Title = actors.Title;

            dataManager.UserRateActors.SaveUserRate(model);
            avg.UpdateAVG(actors.Id);

            return RedirectToAction(nameof(Index), nameof(ActorsController).CutController());
        }
    }
}
