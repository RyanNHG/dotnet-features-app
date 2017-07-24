using Microsoft.AspNetCore.Mvc;

namespace KickSharp.Routes.About
{
    public class Controller : Microsoft.AspNetCore.Mvc.Controller
    {
        [Route("about-us")]
        public IActionResult Index()
        {
            var model = new Model()
            {
                Title = "About Us",
                Intro = "There's a lot about us."
            };

            return View(model);
        }
    }
}