using System.Collections.Generic;
using Kicksharp.Web.Models;
using Mvc = Microsoft.AspNetCore.Mvc;

namespace Kicksharp.Web.Pages.Home
{
    public class HomeController : Mvc.Controller
    {
        // GET
        public Mvc.IActionResult Index()
        {
            var viewModel = new ViewModel()
            {
                Title = "Kicksharp",
                Subtitle = "The coolest templating project ever.",
                Features = new List<Link>()
                {
                    new Link("Fast", "/features/fast"),
                    new Link("Fast", "/features/fast"),
                    new Link("Fast", "/features/fast")
                }
            };

            return View(viewModel);
        }
    }
}