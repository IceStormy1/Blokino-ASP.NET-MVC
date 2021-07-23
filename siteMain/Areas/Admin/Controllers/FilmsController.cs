using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using siteMain.Areas.Admin.Model;
using siteMain.Domain;
using siteMain.Domain.Entities;
using siteMain.Service;

namespace siteMain.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FilmsController : Controller
    {
        private readonly DataManager _dataManager;
        private readonly IWebHostEnvironment _hostingEnvironment;
        public FilmsController(DataManager dataManager, IWebHostEnvironment hostingEnvironment)
        {
            _dataManager = dataManager;
            _hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Edit(Guid id)
        {
            var GetFilmsById = _dataManager.Films.GetFilmsById(id);

            var filmsById = id == default
                ? new FilmEditAdmin()
                {
                    GetActors = _dataManager.Actors.GetActors()
                }
                : new FilmEditAdmin()
                {
                    GetActors = _dataManager.Actors.GetActors(),
                    Id = GetFilmsById.Id,
                    DateAdded = GetFilmsById.DateAdded,
                    Text = GetFilmsById.Text,
                    Title = GetFilmsById.Title,
                    TitleImagePath = GetFilmsById.TitleImagePath
                }; ;
            return View(filmsById);
        }
        [HttpPost]
        public IActionResult Edit(FilmEditAdmin model, IFormFile titleImageFile, Guid[] actorId)
        {
            if (ModelState.IsValid)
            {
                if (titleImageFile != null)
                {
                    model.TitleImagePath = titleImageFile.FileName;
                    using var stream = new FileStream(Path.Combine(_hostingEnvironment.WebRootPath, "images/", titleImageFile.FileName), FileMode.Create);
                    titleImageFile.CopyTo(stream);
                }

                var saveFilms = new Films()
                {
                    Id = model.Id,
                    TitleImagePath = model.TitleImagePath,
                    Title = model.Title,
                    Text = model.Text
                };
                _dataManager.Films.SaveFilms(saveFilms);

                foreach (var actor in actorId)
                {
                    var actorById = _dataManager.Actors.GetActorsById(actor);
                    var filmsAndActors = new FilmsAndActors
                    {
                        IdActor = actorById.Id,
                        IdFilm = saveFilms.Id
                    };
                    _dataManager.FilmsAndActors.SaveFilmsAndActors(filmsAndActors);
                }

                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            _dataManager.Films.DeleteFilms(id);
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }
    }
}