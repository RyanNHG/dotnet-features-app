using Kicksharp.Logic.Services;
using Microsoft.AspNetCore.Mvc;

namespace Kicksharp.Web.Views.About
{
    public class AboutController : Microsoft.AspNetCore.Mvc.Controller
    {
        private ISettings settingsService;

        public AboutController(ISettings settingsService)
        {
            this.settingsService = settingsService;
        }

        public IActionResult Index()
        {
            var model = new ViewModel(
                settingsService.GetGlobal(),
                "About Us",
                "There's a lot about us!"
            );

            return View(model);
        }
    }
}