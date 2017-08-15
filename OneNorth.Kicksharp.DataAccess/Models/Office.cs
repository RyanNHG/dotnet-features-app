using System;

namespace OneNorth.Kicksharp.DataAccess.Models
{
    public class Office
    {
        public Office(Guid id, string slug, string name, string phone, string fax, Address address)
        {
            Id = id;
            Slug = slug;
            Name = name;
            Phone = phone;
            Fax = fax;
            Address = address;
        }

        public Guid Id { get; set; }

        public string Slug { get; set; }

        public string Name { get; }

        public string Phone { get; }

        public string Fax { get; }

        public Address Address { get; }
    }
}
