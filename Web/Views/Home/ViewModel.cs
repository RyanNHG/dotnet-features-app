using System.Collections.Generic;

namespace Kicksharp.Web.Views.Home
{
    public class ViewModel
    {
        public HeaderSection HeaderSection { get; set; }
        public IntroSection IntroSection { get; set; }
        public LinksSection LinksSection { get; set; }
    }

    public class HeaderSection
    {
        public string ImageStyles { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string CtaLabel { get; set; }
    }

    public class IntroSection
    {
        public string Title { get; set; }
        public string ImageStyles { get; set; }
        public string Excerpt { get; set; }
    }

    public class LinksSection
    {
        public string Title { get; set; }
        public IEnumerable<Link> Links { get; set; }
    }

    public class Link
    {
        public string Label { get; set; }
        public string Url { get; set; }
    }
}