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

        public Logic.Models.IGlobalSettings GetGlobal()
        {
            return mocker.GetJson<Models.GlobalSettings>("global-settings.json");
        }
    }
}