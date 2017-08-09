using Kicksharp.Web.Views.Shared;
using Models = Kicksharp.Logic.Models;

namespace Kicksharp.Web.Views
{
    public class ViewModel
    {
        public Navbar Navbar { get; set; }

        public ViewModel (Models.IGlobalSettings settings, bool isHomepage = false)
        {
            this.Navbar = new Navbar(settings.NavbarSettings, isHomepage);
        }
    }
}