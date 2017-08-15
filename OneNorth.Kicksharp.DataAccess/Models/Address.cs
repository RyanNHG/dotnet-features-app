namespace OneNorth.Kicksharp.DataAccess.Models
{
    public class Address
    {
        public Address(string line1, string line2, string line3, string city, string state, int zipCode, string country)
        {
            Line1 = line1;
            Line2 = line2;
            Line3 = line3;
            City = city;
            State = state;
            ZipCode = zipCode;
            Country = country;
        }

        public string Line1 { get; }

        public string Line2 { get; }

        public string Line3 { get; }

        public string City { get; }

        public string State { get; }

        public int ZipCode { get; }

        public string Country { get; }
    }
}
