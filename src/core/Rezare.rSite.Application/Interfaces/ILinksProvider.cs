using System.Collections.Generic;
using Rezare.rSite.Domain.ValueObjects;

namespace Rezare.rSite.Application.Interfaces
{
    /// <summary>
    /// Provides the links.
    /// </summary>
    public interface ILinksProvider
    {
        /// <summary>
        /// Gets the links.
        /// </summary>
        /// <returns>List of links.</returns>
        IEnumerable<Link> GetLinks();
    }
}
