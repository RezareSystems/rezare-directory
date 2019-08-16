using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Rezare.rSite.Api.Models;
using Rezare.rSite.Application.Interfaces;
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

        /// <summary>
        /// Create new link
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [Route("create")]
        [HttpPost]
        public IActionResult Create([FromBody]CreateLinkRequest request)
        {
            var link = new Link(
                new Uri(request.Url),
                request.Name,
                request.Description
            );

            var linkId = linksProvider.CreateLink(link);
            var response = new CreateLinkResponse
            {
                Id = Guid.Parse(linkId)
            };

            return Ok(response);
        }


        /// <summary>
        /// Seed link
        /// </summary>
        /// <returns></returns>
        [Route("seed")]
        public IActionResult Seed()
        {
            var links = GetLinks();
            foreach (var link in links)
            {
                var linkId = linksProvider.CreateLink(link);
            }
            return Ok();
        }

        /// <summary>
        /// 
        /// </summary>
        public List<Link> GetLinks()
        {
            var link1 = new Link(
                   new Uri("https://www.2talk.co.nz/login.html"),
                   "2talk",
                   "The 2talk portal for managing your work phone.");

            var link2 = new Link(
                new Uri("https://buildmaster.rezare.co.nz/"),
                "BuildMaster",
                "Deployment system for Rezare projects.");

            var link3 = new Link(
                new Uri("https://my.workflowmax.com"),
                "WorkflowMax",
                "Time recording.");

            var link4 = new Link(
                new Uri("https://breezy.hr/signin"),
                "Breezy",
                "Candidate Recruitment Platform.");

            var link5 = new Link(
                new Uri("https://secure.rezare.co.nz/gemini/"),
                "Gemini",
                "Story and issue tracking.");

            var link6 = new Link(
                new Uri("https://github.com/rezaresystems"),
                "Rezare Github",
                "Rezare's Github page for repositories.");

            var link7 = new Link(
                new Uri("https://coffee.rezare.co.nz"),
                "Coffee Ordering",
                "Hot drink selection for Rezare Staff meetings.");

            return new List<Link>
            {
                link1,
                link2,
                link3,
                link4,
                link5,
                link6,
                link7
            };
        }
    }
}
