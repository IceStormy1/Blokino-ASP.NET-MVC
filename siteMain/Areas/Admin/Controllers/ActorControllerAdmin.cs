using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using siteMain.Domain;
using siteMain.Domain.Entities;
using siteMain.Service;

namespace siteMain.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ActorControllerAdmin : Controller
    {
        private readonly DataManager _dataManager;
        private readonly IWebHostEnvironment _hostingEnvironment;
        public ActorControllerAdmin(DataManager dataManager, IWebHostEnvironment hostingEnvironment)
        {
            _dataManager = dataManager;
            _hostingEnvironment = hostingEnvironment;
        }

        public IActionResult EditActor(Guid id)
        {
            var actorsById = id == default ? new Actors() : _dataManager.Actors.GetActorsById(id);
            return View(actorsById);
        }
        [HttpPost]
        public IActionResult EditActor(Actors model, IFormFile titleImageFile, Guid [] filmId)
        {
            if (ModelState.IsValid)
            {
                if (titleImageFile != null)
                {
                    model.TitleImagePath = titleImageFile.FileName;
                    using var stream = new FileStream(Path.Combine(_hostingEnvironment.WebRootPath, "images/", titleImageFile.FileName), FileMode.Create);
                    titleImageFile.CopyTo(stream);
                }
                _dataManager.Actors.SaveActors(model);
                foreach (var film in filmId)
                {
                    var filmsById = _dataManager.Films.GetFilmsById(film);

                    var filmsAndActors = new FilmsAndActors
                    {
                        IdFilm = filmsById.Id,
                        IdActor = model.Id,
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
            _dataManager.Actors.DeleteActors(id);
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }
    }
}
