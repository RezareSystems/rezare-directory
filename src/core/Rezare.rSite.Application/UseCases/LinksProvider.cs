using System.Collections.Generic;
using Rezare.rSite.Application.Interfaces;
using Rezare.rSite.Domain.ValueObjects;

namespace Rezare.rSite.Application.UseCases
{
    /// <summary>
    /// LinksProvider.
    /// </summary>
    public class LinksProvider : ILinksProvider
    {
        private readonly ILinkRepository linkRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="LinksProvider"/> class.
        /// </summary>
        /// <param name="linkRepository">The link repository.</param>
        public LinksProvider(ILinkRepository linkRepository)
        {
            this.linkRepository = linkRepository;
        }

        /// <summary>
        /// Get Links.
        /// </summary>
        /// <returns>The list of Links.</returns>
        public IEnumerable<Link> GetLinks() => linkRepository.GetLinks();
    }
}
