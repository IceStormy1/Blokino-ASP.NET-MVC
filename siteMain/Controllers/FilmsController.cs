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
    public class FilmsController : Controller
    {
        private readonly DataManager _dataManager;
        readonly UserManager<IdentityUser> _manager;
        
        public FilmsController(DataManager dataManager, UserManager<IdentityUser> manager)
        {
            _dataManager = dataManager;
            _manager = manager;
        }
        
        public IActionResult Index(Guid id, string sortOrder)
        {
            if (id != default)
            {
                var filmsById = _dataManager.Films.GetFilmsById(id);

                return View("Show", new FilmsEdit()
                {
                    Id = filmsById.Id,
                    Title = filmsById.Title,
                    AvgRateFilm = filmsById.AvgRateFilm,
                    TitleImagePath = filmsById.TitleImagePath,
                    Text = filmsById.Text,
                    UsersId = _manager.GetUserId(User),
                    GetUserById = _dataManager.UserRateFilms.GetUserByIdFilm(filmsById.Id.ToString(), _manager.GetUserId(User)).Count() == 1,
                    UsersMark = _dataManager.UserRateFilms.GetUserMark(filmsById.Id.ToString(), _manager.GetUserId(User)),
                    FilmsAndActors = filmsById.FilmsAndActors.Select(x=>new FilmsAndActorsModel()
                    {
                        Title = _dataManager.Actors.GetActorsById(x.IdActor).Title,
                        Id = _dataManager.Actors.GetActorsById(x.IdActor).Id
                    }).ToList()
                });
            }

            ViewBag.DateSortParm = sortOrder == "Avg" ? "Avg" : "avg_desc";
            var sort = _dataManager.Films.GetFilms();

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
        public IActionResult Mark(Mark mark, UserRatesFilm model, Guid id)
        {
            var filmsById = _dataManager.Films.GetFilmsById(id);
            var avg = new AvgRateFilm(_dataManager);
            
            model.UsersId = _manager.GetUserId(User);
           // model.UserName = _manager.GetUserName(User);
            model.RateFilm = mark.MarkValue;
            model.IdFilm = filmsById.Id;
           // model.Title = filmsById.Title;
            model.RateFilm = mark.MarkValue;
           
            _dataManager.UserRateFilms.SaveUserRate(model);
            avg.UpdateAvg(filmsById.Id);

            return RedirectToAction(nameof(Index), nameof(FilmsController).CutController());
        }
    }
}
