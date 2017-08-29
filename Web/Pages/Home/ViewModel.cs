using System.Collections.Generic;
using Kicksharp.Web.Models;

namespace Kicksharp.Web.Pages.Home
{
    public class ViewModel
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public IEnumerable<Link> Features { get; set; }
    }
}