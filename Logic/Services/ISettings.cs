using Kicksharp.Logic.Models;

namespace Kicksharp.Logic.Services
{
    public interface ISettings
    {
        IGlobalSettings GetGlobal();
        IHomepageSettings GetHomepage();
    }
}