using Logic = Kicksharp.Logic;

namespace Kicksharp.Logic.Json.Services
{
    public class Settings : Logic.Services.ISettings
    {
        private IMocker mocker;

        public Settings(IMocker mocker)
        {
            this.mocker = mocker;
        }

        public Logic.Models.IHomepageSettings GetHomepage()
        {
            return mocker.GetJson<Models.HomepageSettings>("homepage-settings.json");
        }
    }
}