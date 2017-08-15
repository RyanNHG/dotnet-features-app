using System;
using System.Collections.Generic;

namespace OneNorth.Kicksharp.DataAccess.Models
{
    public class ProfessionalSearchCriteria
    {
        public ProfessionalSearchCriteria(IList<string> keywords, string lastNameLetter, Guid officeId)
        {
            Keywords = keywords;
            LastNameLetter = lastNameLetter;
            OfficeId = officeId;
        }

        public IList<string> Keywords { get; set; }

        public string LastNameLetter { get; set; }

        public Guid OfficeId { get; }
    }
}
