using Kicksharp.Logic.Models;

namespace Kicksharp.Logic.Services
{
    public interface ISettings
    {
        IHomepageSettings GetHomepage();
    }
}