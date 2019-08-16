using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Rezare.rSite.Domain.ValueObjects;

namespace Rezare.rSite.Application.Interfaces
{
    /// <summary>
    /// ILinkRepository.
    /// </summary>
    public interface ILinkRepository
    {
        /// <summary>
        /// Create new link
        /// </summary>
        /// <param name="link"></param>
        Task<string> Create(Link link);

        /// <summary>
        /// Gets the links.
        /// </summary>
        /// <returns>The links.</returns>
        Task<IEnumerable<Link>> GetLinks();
    }
}
