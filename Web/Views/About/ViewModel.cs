using Kicksharp.Logic.Models;

namespace Kicksharp.Web.Views.About
{
    public class ViewModel : Web.Views.ViewModel
    {
        public string Title {get; set;}
        public string Intro {get; set;}

        public ViewModel (IGlobalSettings globalSettings, string title, string intro) : base(globalSettings)
        {
            this.Title = title;
            this.Intro = intro;
        }
    }
}