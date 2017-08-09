using System.Collections.Generic;
using Models = Kicksharp.Logic.Models;
using Types = Kicksharp.Logic.Types;
using Utilities = Kicksharp.Web.Utilities;

namespace Kicksharp.Web.Views.Home
{
    public class ViewModel : Web.Views.ViewModel
    {
        public HeaderSection HeaderSection { get; set; }
        public IntroSection IntroSection { get; set; }
        public Types.LinksSection LinksSection { get; set; }

        public ViewModel(Models.IGlobalSettings globalSettings, Models.IHomepageSettings settings) : base(globalSettings, true)
        {
            this.HeaderSection = new HeaderSection(settings.HeaderSection);
            this.IntroSection = new IntroSection(settings.IntroSection);
            this.LinksSection = settings.LinksSection;
        }
    }

    public class HeaderSection
    {
        public string ImageStyles { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string CtaLabel { get; set; }

        public HeaderSection(Types.HeaderSection section)
        {
            this.ImageStyles = Utilities.Images.BackgroundUrlStyle(section.ImageUrl);
            this.Title = section.Title;
            this.Subtitle = section.Subtitle;
            this.CtaLabel = section.CtaLabel;
        }
    }

    public class IntroSection
    {
        public string Title { get; set; }
        public string ImageStyles { get; set; }
        public string Excerpt { get; set; }

        public IntroSection(Types.IntroSection section)
        {
            this.Title = section.Title;
            this.ImageStyles = Utilities.Images.BackgroundUrlStyle(section.ImageUrl);
            this.Excerpt = section.Excerpt;
        }
    }

}