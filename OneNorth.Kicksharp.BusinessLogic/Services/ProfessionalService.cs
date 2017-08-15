using OneNorth.Kicksharp.BusinessLogic.Models;
using OneNorth.Kicksharp.DataAccess;
using System;
using System.Collections.Generic;

namespace OneNorth.Kicksharp.BusinessLogic.Services
{
    public class ProfessionalService : IProfessionalService
    {
        protected IProfessionalRepository ProfessionalRepository;

        public ProfessionalService(IProfessionalRepository professionalRepository)
        {
            ProfessionalRepository = professionalRepository;
        }

        public IList<Professional> GetAll(Context context)
        {
            throw new NotImplementedException();
        }

        public Professional GetById(Context context, Guid Id)
        {
            throw new NotImplementedException();
        }

        public IList<Professional> Search(Context context, ProfessionalSearchCriteria searchCriteria)
        {
            throw new NotImplementedException();
        }
    }
}
