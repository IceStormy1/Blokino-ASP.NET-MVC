﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using siteMain.Domain;
using siteMain.Domain.Entities;
using siteMain.Models;
using siteMain.Service;

namespace siteMain.Controllers
{
    public class ActorsController : Controller
    {
        private readonly DataManager _dataManager;
        readonly UserManager<IdentityUser> _manager;

        public ActorsController(DataManager dataManager, UserManager<IdentityUser> manager)
        {
            _dataManager = dataManager;
            _manager = manager;
        }

        public IActionResult Index(Guid id, string sortOrder)
        {
            if (id != default)
            {
                var actor = _dataManager.Actors.GetActorsById(id);
                
                return View("ShowActor", new ActorsEdit
                {
                    Id = actor.Id,
                    Title = actor.Title,
                    AvgRateActor = actor.AvgRateActor,
                    TitleImagePath = actor.TitleImagePath,
                    Text = actor.Text,
                    UsersId = _manager.GetUserId(User),
                    GetUserById = _dataManager.UserRateActors.GetUserByIdFilm(actor.Id.ToString(), _manager.GetUserId(User)).Count() == 1,
                    UsersMark = _dataManager.UserRateActors.GetUserMark(actor.Id.ToString(), _manager.GetUserId(User)),
                    FilmsAndActors = actor.FilmsAndActors.Select(x => new FilmsAndActorsModel
                    {
                        Title = _dataManager.Films.GetFilmsById(x.IdFilm).Title,
                        Id = _dataManager.Films.GetFilmsById(x.IdFilm).Id
                    }).ToList()
                });
            }

            ViewBag.TextField = _dataManager.TextFields.GetTextFieldsByCodeWord("PageServices");
            ViewBag.DateSortParm = sortOrder == "Avg" ? "Avg": "avg_desc";
            var sort = _dataManager.Actors.GetActors();
            
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
        }
        [HttpPost]
        public IActionResult Mark(Mark mark, UserRatesActors model, Guid id)
        {
            var actors = _dataManager.Actors.GetActorsById(id);
            var avg = new AvgRateActor(_dataManager);

            model.UsersId = _manager.GetUserId(User).ToString();
            model.RateActor = mark.MarkValue;
            model.IdActor = actors.Id;
            
            _dataManager.UserRateActors.SaveUserRate(model);
            avg.UpdateAvg(actors.Id);

            return RedirectToAction(nameof(Index), nameof(ActorsController).CutController());
        }
    }
}
