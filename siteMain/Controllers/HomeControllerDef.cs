using Microsoft.AspNetCore.Mvc;
using siteMain.Domain;

namespace siteMain.Controllers
{
    public class HomeControllerDef : Controller
    {
        private readonly DataManager _dataManager;

        public HomeControllerDef(DataManager dataManager)
        {
            _dataManager = dataManager;
        }

        public IActionResult Index()
        {
            return View(_dataManager.Films.GetFilms());
        }

        public IActionResult Contacts()
        {
            return View(_dataManager.TextFields.GetTextFieldsByCodeWord("PageContacts"));
        }
    }
}
