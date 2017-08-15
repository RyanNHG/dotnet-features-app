using System;
using System.Collections.Generic;
using System.Text;
using OneNorth.Kicksharp.DataAccess.Models;
using System.IO;
using System.Linq;

namespace OneNorth.Kicksharp.DataAccess.Json
{
    public class OfficeRepository : IOfficeRepository
    {
        private List<Office> offices;

        public OfficeRepository()
        {
            populateOffices();
        }

        IList<Office> IOfficeRepository.GetAll(Context context)
        {
            return offices;
        }

        Office IOfficeRepository.GetById(Context context, Guid Id)
        {
            return offices.First(o => o.Id.Equals(Id));
        }

        private void populateOffices()
        {
            offices = new List<Office>();

            offices.Add(new Office(new Guid("00000001-0000-000-0000-000000000001"), "chicago", "Chicago", "(312) 123-4567", "(123) 456-7890", new Address("222 N LaSalle", null, null, "Chicago", "Illinois", 60001, "United States of America")));
            offices.Add(new Office(new Guid("00000001-0000-000-0000-000000000002"), "chicago", "Chicago", "(312) 123-4567", "(123) 456-7890", new Address("222 N LaSalle", null, null, "Chicago", "Illinois", 60001, "United States of America")));
            offices.Add(new Office(new Guid("00000001-0000-000-0000-000000000003"), "chicago", "Chicago", "(312) 123-4567", "(123) 456-7890", new Address("222 N LaSalle", null, null, "Chicago", "Illinois", 60001, "United States of America")));
            offices.Add(new Office(new Guid("00000001-0000-000-0000-000000000004"), "chicago", "Chicago", "(312) 123-4567", "(123) 456-7890", new Address("222 N LaSalle", null, null, "Chicago", "Illinois", 60001, "United States of America")));
            offices.Add(new Office(new Guid("00000001-0000-000-0000-000000000005"), "chicago", "Chicago", "(312) 123-4567", "(123) 456-7890", new Address("222 N LaSalle", null, null, "Chicago", "Illinois", 60001, "United States of America")));
        }
    }
}
