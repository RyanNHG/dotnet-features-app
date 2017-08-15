using System;

namespace OneNorth.Kicksharp.DataAccess.Models
{
    public class ProfessionalOffice
    {
        public ProfessionalOffice(Guid professionalId, Guid officeId, string phone, string fax)
        {
            ProfessionalId = professionalId;
            OfficeId = officeId;
            Phone = phone;
            Fax = fax;
        }

        public Guid ProfessionalId { get; }

        public Guid OfficeId { get; }

        public string Phone { get; }

        public string Fax { get; }
    }
}
