using System.Collections.Generic;

namespace Kicksharp.Logic.Types
{
    public struct NavbarSettings
    {
        public string LogoUrl { get; set; }
        public IEnumerable<Link> Links { get; set;}
    }
}