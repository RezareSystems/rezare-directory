using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Rezare.rSite.Api.Models;
using Rezare.rSite.Application.Interfaces;

namespace Rezare.rSite.Api.Controllers
{
    /// <summary>
    /// Link.
    /// </summary>
    [Route("api/links")]
    [ApiController]
    public class LinksController : ControllerBase
    {
        private readonly ILinksProvider linksProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="LinksController"/> class.
        /// </summary>
        /// <param name="linksProvider">The links provider.</param>
        public LinksController(ILinksProvider linksProvider)
        {
            this.linksProvider = linksProvider;
        }

        /// <summary>
        /// Gets a bunch of links.
        /// </summary>
        /// <remarks>
        /// https://ardalis.com/your-api-and-view-models-should-not-reference-domain-models
        /// https://docs.microsoft.com/en-us/aspnet/core/web-api/action-return-types?view=aspnetcore-2.2 .
        /// </remarks>
        /// <returns>Some links.</returns>
        [HttpGet]
        public ActionResult<IEnumerable<LocationLink>> Get()
        {
            var linksList = linksProvider.GetLinks();

            var locationLinks = linksList.Select(
                    link => new LocationLink
                    {
                        Description = link.Description,
                        Name = link.Name,
                        Uri = link.Uri
                    })
                .ToList();

            return locationLinks;
        }
    }
}
