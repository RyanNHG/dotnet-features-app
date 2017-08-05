using Kicksharp.Logic.Models;
using Kicksharp.Logic.Types;

namespace Kicksharp.Logic.Json.Models
{
    public class HomepageSettings : IHomepageSettings
    {
        public HeaderSection HeaderSection { get; set; }
        public IntroSection IntroSection { get; set; }
        public LinksSection LinksSection { get; set; }
    }
}