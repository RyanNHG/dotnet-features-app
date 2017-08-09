using Kicksharp.Logic.Models;
using Kicksharp.Logic.Types;

namespace Kicksharp.Logic.Json.Models
{
    public class GlobalSettings : IGlobalSettings
    {
        public NavbarSettings NavbarSettings { get; set; }
    }
}