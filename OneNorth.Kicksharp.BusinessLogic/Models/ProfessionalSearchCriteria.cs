using System.Collections.Generic;

namespace OneNorth.Kicksharp.BusinessLogic.Models
{
    public class ProfessionalSearchCriteria
    {
        public IList<string> Keywords { get; set; }

        public string LastNameLetter { get; set; }
    }
}
