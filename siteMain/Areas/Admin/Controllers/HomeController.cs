using Microsoft.AspNetCore.Mvc;
using siteMain.Areas.Admin.Model;
using siteMain.Domain;

namespace siteMain.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly DataManager _dataManager;

        public HomeController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }
        
        public IActionResult Index()
        {
            return View("Index", new FilmsAndActorsAdmin()
            {
                Films = _dataManager.Films.GetFilms(),
                Actors = _dataManager.Actors.GetActors()
            });
        }
    }
}