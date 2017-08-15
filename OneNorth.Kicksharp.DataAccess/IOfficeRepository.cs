using OneNorth.Kicksharp.DataAccess.Models;
using System;
using System.Collections.Generic;

namespace OneNorth.Kicksharp.DataAccess
{
    /// <summary>
    /// The Office repository.
    /// </summary>
    public interface IOfficeRepository
    {
        Office GetById(Context context, Guid Id);

        IList<Office> GetAll(Context context);
    }
}
