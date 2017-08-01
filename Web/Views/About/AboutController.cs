using Microsoft.AspNetCore.Mvc;

namespace Kicksharp.Views.About
{
    public class AboutController : Microsoft.AspNetCore.Mvc.Controller
    {
        public IActionResult Index()
        {
            var model = new ViewModel()
            {
                Title = "About Us",
                Intro = "There's a lot about us!"
            };

            return View(model);
        }
    }
}