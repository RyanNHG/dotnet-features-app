using System;

namespace OneNorth.Kicksharp.DataAccess.Models
{
    public class Professional
    {
        public Professional(Guid id, string firstName, string middleName, string lastName, string maidenName)
        {
            Id = id;
            FirstName = FirstName;
            MiddleName = middleName;
            LastName = lastName;
            MaidenName = maidenName;
        }

        public Guid Id { get; }

        public string FirstName { get; }

        public string MiddleName { get; }

        public string LastName { get; }

        public string MaidenName { get; }

        public string Email { get; }

        public string Phone { get; }

        public string Mobile { get; }

        public string Fax { get; }
    }
}
