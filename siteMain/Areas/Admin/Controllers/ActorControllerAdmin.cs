using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
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
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostingEnvironment;
        public ActorControllerAdmin(DataManager dataManager, IWebHostEnvironment hostingEnvironment)
        {
            this.dataManager = dataManager;
            this.hostingEnvironment = hostingEnvironment;
        }

        public IActionResult EditActor(Guid id)
        {
            var entity = id == default ? new Actors() : dataManager.Actors.GetActorsById(id);
            return View(entity);
        }
        [HttpPost]
        public IActionResult EditActor(Actors model, IFormFile titleImageFile, string [] FilmName, FilmsAndActors filmsAndActors)
        {
            if (ModelState.IsValid)
            {
                if (titleImageFile != null)
                {
                    model.TitleImagePath = titleImageFile.FileName;
                    using var stream = new FileStream(Path.Combine(hostingEnvironment.WebRootPath, "images/", titleImageFile.FileName), FileMode.Create);
                    titleImageFile.CopyTo(stream);
                }
                dataManager.Actors.SaveActors(model);
                foreach (var film in FilmName)
                {
                    var films = dataManager.ServiceItems.GetServiceItemByFilmName(film);
                    var NewfilmsAndActors = new FilmsAndActors
                    {
                        IdFilm = films.Id, 
                        Title = films.Title, 
                        IdActor = model.Id, 
                        NameActor = model.Title
                    };
                    dataManager.FilmsAndActors.SaveFilmsAndActors(NewfilmsAndActors);
                }
                
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            //dataManager.FilmsAndActors.DeleteFilmAndActors(id);
            dataManager.Actors.DeleteActors(id);
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }
    }
}
