using System.Collections.Generic;
using System.Threading.Tasks;
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
        /// Create new link
        /// </summary>
        /// <param name="link"></param>
        public string CreateLink(Link link)
        {
            var response = linkRepository.Create(link);
            return response.Result;
        }

        /// <summary>
        /// Get Links.
        /// </summary>
        /// <returns>The list of Links.</returns>
        public IEnumerable<Link> GetLinks() {
            return linkRepository.GetLinks().Result;
        }
    }
}
