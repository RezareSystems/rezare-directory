using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Rezare.rSite.Application.UseCases;
using Rezare.rSite.Domain.ValueObjects;

namespace Rezare.rSite.Api.Controllers
{
    /// <summary>
    /// Link.
    /// </summary>
    [Route("api/links")]
    [ApiController]
    public class LinksController : ControllerBase
    {
        /// <summary>
        /// Gets a bunch of links.
        /// </summary>
        /// <remarks>
        /// https://ardalis.com/your-api-and-view-models-should-not-reference-domain-models
        /// https://docs.microsoft.com/en-us/aspnet/core/web-api/action-return-types?view=aspnetcore-2.2 .
        /// </remarks>
        /// <returns>Some links.</returns>
        [HttpGet]
        public ActionResult<IEnumerable<Link>> Get()
        {
            var linksList = LinksProvider.GetLinks();

            return linksList.ToList();
        }
    }
}
