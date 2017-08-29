using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Kicksharp.Web.Partials.MetaHeader
{
    [ViewComponent(Name = "MetaHeader")]
    public class Component : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("Index", new ViewModel()
            {
                Title = "Kicksharp",
                Description = "The coolest templating project ever."
            });
        }
    }
}