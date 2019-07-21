using System.Collections;
using System.Collections.Generic;
using Rezare.rSite.Domain.ValueObjects;

namespace Rezare.rSite.Application.Interfaces
{
    /// <summary>
    /// ILinkRepository.
    /// </summary>
    public interface ILinkRepository
    {
        /// <summary>
        /// Gets the links.
        /// </summary>
        /// <returns>The links.</returns>
        IEnumerable<Link> GetLinks();
    }
}
