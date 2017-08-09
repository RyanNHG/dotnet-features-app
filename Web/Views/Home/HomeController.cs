using Mvc = Microsoft.AspNetCore.Mvc;
using Models = Kicksharp.Logic.Models;
using Services = Kicksharp.Logic.Services;

namespace Kicksharp.Web.Views.Home
{
    public class HomeController : Mvc.Controller
    {
        private Services.ISettings settingsService;

        public HomeController (Services.ISettings settingsService)
        {
            this.settingsService = settingsService;
        }
        
        public Mvc.IActionResult Index()
        {
            var globalSettings = this.settingsService.GetGlobal();
            var homepageSettings = this.settingsService.GetHomepage();

            ViewModel viewModel = new ViewModel(globalSettings, homepageSettings);

            return View(viewModel);
        }
    }
}