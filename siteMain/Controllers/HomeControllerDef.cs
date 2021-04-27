using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using siteMain.Domain;

namespace siteMain.Controllers
{
    public class HomeControllerDef : Controller
    {
        private readonly DataManager dataManager;

        public HomeControllerDef(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Index()
        {
            return View(dataManager.TextFields.GetTextFieldsByCodeWord("PageIndex"));
        }
        public IActionResult Contacts()
        {
            return View(dataManager.TextFields.GetTextFieldsByCodeWord("PageContacts"));
        }
    }
}
