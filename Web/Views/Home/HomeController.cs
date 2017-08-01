using Kicksharp.Services;
using Microsoft.AspNetCore.Mvc;

namespace Kicksharp.Views.Home
{
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        private ISettingsService settingsService;

        public HomeController (ISettingsService settingsService)
        {
            this.settingsService = settingsService;
        }
        public IActionResult Index()
        {
            var model = this.settingsService.GetHomepage();

            return View(model);
        }
    }
}