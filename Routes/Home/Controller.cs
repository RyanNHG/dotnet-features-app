using Microsoft.AspNetCore.Mvc;

namespace KickSharp.Routes.Home
{
    public class Controller : Microsoft.AspNetCore.Mvc.Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            var model = new Model()
            {
                Title = "This is the homepage!",
                Subtitle = "You did it!"
            };

            return View(model);
        }
    }
}