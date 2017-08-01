using Kicksharp.Services;
using Home = Kicksharp.Web.Views.Home;

namespace Kicksharp.Services.Mock
{
    public class SettingsService : ISettingsService
    {
        private IMocker mocker;

        public SettingsService(IMocker mocker)
        {
            this.mocker = mocker;
        }

        public Home.ViewModel GetHomepage()
        {
            return mocker.GetJson<Home.ViewModel>("homepage-settings.json");
        }

        private string backgroundUrlStyle(string url)
        {
            return $"background-image: url({url})";
        }
    }
}