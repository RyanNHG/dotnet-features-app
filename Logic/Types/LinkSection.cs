using System.Collections.Generic;

namespace Kicksharp.Logic.Types
{
    public struct LinksSection
    {
        public string Title { get; set; }
        public IEnumerable<Link> Links { get; set; }
    }
}