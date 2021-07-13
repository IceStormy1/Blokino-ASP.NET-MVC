using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
            var filmsById = id == default ? new Films() : _dataManager.Films.GetFilmsById(id);
            return View(filmsById);
        }
        [HttpPost]
        public IActionResult Edit(Films model, IFormFile titleImageFile, Guid[] actorId)
        {
            if (ModelState.IsValid)
            {
                if (titleImageFile != null)
                {
                    model.TitleImagePath = titleImageFile.FileName;
                    using var stream = new FileStream(Path.Combine(_hostingEnvironment.WebRootPath, "images/", titleImageFile.FileName), FileMode.Create);
                    titleImageFile.CopyTo(stream);
                }
                _dataManager.Films.SaveFilms(model);

                foreach (var actor in actorId)
                {
                    var actorById = _dataManager.Actors.GetActorsById(actor);
                    var filmsAndActors = new FilmsAndActors
                    {
                        IdFilm = model.Id,
                        IdActor = actorById.Id,
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