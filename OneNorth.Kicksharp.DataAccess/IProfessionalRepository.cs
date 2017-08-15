using OneNorth.Kicksharp.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneNorth.Kicksharp.DataAccess
{
    /// <summary>
    /// The Professional repository.
    /// </summary>
    public interface IProfessionalRepository
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
    }
}
