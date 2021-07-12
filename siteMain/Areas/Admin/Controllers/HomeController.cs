using Microsoft.AspNetCore.Mvc;
using siteMain.Domain;

namespace siteMain.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly DataManager _dataManager;

        public HomeController(DataManager dataManager)
        {
            this._dataManager = dataManager;
        }

        public IActionResult Index()
        {
            return View(_dataManager.Films.GetFilms());
        }
    }
}