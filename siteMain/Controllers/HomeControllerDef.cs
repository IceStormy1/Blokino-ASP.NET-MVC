using Microsoft.AspNetCore.Mvc;
using siteMain.Domain;

namespace siteMain.Controllers
{
    public class HomeControllerDef : Controller
    {
        private readonly DataManager _dataManager;

        public HomeControllerDef(DataManager dataManager)
        {
            this._dataManager = dataManager;
        }

        public IActionResult Index()
        {
            return View(_dataManager.ServiceItems.GetServiceItems());
        }

        public IActionResult Contacts()
        {
            return View(_dataManager.TextFields.GetTextFieldsByCodeWord("PageContacts"));
        }
    }
}
