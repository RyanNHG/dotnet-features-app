using Home = Kicksharp.Web.Views.Home;

namespace Kicksharp.Services
{
    public interface ISettingsService
    {
        Home.ViewModel GetHomepage();
    }
}