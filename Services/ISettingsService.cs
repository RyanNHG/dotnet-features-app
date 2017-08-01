using Home = Kicksharp.Views.Home;

namespace Kicksharp.Services
{
    public interface ISettingsService
    {
        Home.ViewModel GetHomepage();
    }
}