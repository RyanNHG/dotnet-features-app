using System.Collections.Generic;
using Kicksharp.Logic.Types;

namespace Kicksharp.Web.Views.Shared
{
    public class Navbar
    {
        public static string PartialName = "Navbar.cshtml";
        public string LogoUrl { get; set; }
        public IEnumerable<Link> Links { get; set; }
        public string ModifierClass { get {
            return (this.IsTransparent) ? "navbar--transparent" : "";
        } }

        private bool IsTransparent { get; set; }

        public Navbar(NavbarSettings settings, bool isTransparent = false)
        {
            this.LogoUrl = settings.LogoUrl;
            this.Links = settings.Links;
            this.IsTransparent = isTransparent;
        }
    }
}