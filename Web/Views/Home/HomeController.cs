using Microsoft.AspNetCore.Mvc;

namespace KickSharp.Routes.Home
{
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        public IActionResult Index()
        {
            var model = new ViewModel()
            {
                Title = "This is the homepage!",
                Subtitle = "You did it!"
            };

            return View(model);
        }
    }
}