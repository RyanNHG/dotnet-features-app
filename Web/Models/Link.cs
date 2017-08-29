namespace Kicksharp.Web.Models
{
    public class Link
    {
        public Link(string label, string url)
        {
            Label = label;
            Url = url;
        }

        public string Label { get; set; }
        public string Url { get; set; }
    }
}
