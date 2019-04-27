using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

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
        /// https://docs.microsoft.com/en-us/aspnet/core/web-api/action-return-types?view=aspnetcore-2.2 .
        /// </remarks>
        /// <returns>Some links.</returns>
        [HttpGet]
        public ActionResult<IEnumerable<Link>> Get()
        {
            var link1 = new Link
            {
                Uri = new Uri("https://www.2talk.co.nz/login.html"),
                Name = "2talk",
                Description = "The 2talk portal for managing your work phone."
            };

            var link2 = new Link
            {
                Uri = new Uri("https://buildmaster.rezare.co.nz/"),
                Name = "BuildMaster",
                Description = "Deployment system for Rezare projects."
            };

            return new[] { link1, link2 };
        }

        /// <summary>
        /// Link.
        /// </summary>
        public class Link
        {
            /// <summary>
            /// Gets or sets the Uri.
            /// </summary>
            public Uri Uri { get; set; }

            /// <summary>
            /// Gets or sets the name.
            /// </summary>
            public string Name { get; set; }

            /// <summary>
            /// Gets or sets the description.
            /// </summary>
            public string Description { get; set; }
        }
    }
}
