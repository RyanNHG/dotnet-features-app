using Microsoft.AspNetCore.Mvc;

namespace KickSharp.Routes.About
{
    public class AboutController : Microsoft.AspNetCore.Mvc.Controller
    {
        public IActionResult Index()
        {
            var model = new Model()
            {
                Title = "About Us",
                Intro = "There's a lot about us!"
            };

            return View(model);
        }
    }
}