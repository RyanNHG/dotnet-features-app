using System.Collections.Generic;

namespace Kicksharp.Views.Home
{
    public struct ViewModel
    {
        public HeaderSection HeaderSection { get; set; }
        public IntroSection IntroSection { get; set; }
        public LinksSection LinksSection { get; set; }
    }

    public struct HeaderSection
    {
        public string ImageStyles { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string CtaLabel { get; set; }
    }

    public struct IntroSection
    {
        public string Title { get; set; }
        public string ImageStyles { get; set; }
        public string Excerpt { get; set; }
    }

    public struct LinksSection
    {
        public string Title { get; set; }
        public IEnumerable<Link> Links { get; set; }
    }

    public struct Link
    {
        public string Label { get; set; }
        public string Url { get; set; }
    }
}