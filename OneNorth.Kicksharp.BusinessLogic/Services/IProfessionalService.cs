using OneNorth.Kicksharp.BusinessLogic.Models;
using System;
using System.Collections.Generic;

namespace OneNorth.Kicksharp.BusinessLogic.Services
{
    /// <summary>
    /// The Professional service.
    /// </summary>
    public interface IProfessionalService
    {
        /// <summary>
        /// Get a Professional by an Id.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="Id">The Id of the Professional.</param>
        /// <returns>A Professional.</returns>
        Professional GetById(Context context, Guid Id);

        /// <summary>
        /// Gets all Professionals.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <returns>A list of Professionals.</returns>
        IList<Professional> GetAll(Context context);

        /// <summary>
        /// Performs a search on Professionals.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="searchCriteria">The search criteria.</param>
        /// <returns>A list of Professionals.</returns>
        IList<Professional> Search(Context context, ProfessionalSearchCriteria searchCriteria);

        // TODO: define all methods needed to access professionals.
    }
}
