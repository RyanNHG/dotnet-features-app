using Microsoft.AspNetCore.Mvc;

namespace features_app.Features.Home
{
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        public IActionResult Index()
        {
            var model = new ViewModel()
            {
                Title = "Oh boy.",
                Subtitle = "I did it!"
            };

            return View(model);
        }
    }
}