using System;
using System.Collections.Generic;
using Rezare.rSite.Application.Interfaces;
using Rezare.rSite.Domain.ValueObjects;

namespace Rezare.rSite.Persistence
{
    /// <summary>
    /// Link Repository.
    /// </summary>
    public class LinkRepository : ILinkRepository
    {
        /// <summary>
        /// Gets the links.
        /// </summary>
        /// <returns>
        /// The links.
        /// </returns>
        public IEnumerable<Link> GetLinks()
        {
#pragma warning disable S1075
            var path1 = "https://www.2talk.co.nz/login.html";
            var path2 = "https://buildmaster.rezare.co.nz/";
#pragma warning restore S1075

            var link1 = new Link(
                new Uri(path1),
                "2talk",
                "The 2talk portal for managing your work phone.");

            var link2 = new Link(
                new Uri(path2),
                "BuildMaster",
                "Deployment system for Rezare projects.");

            return new[] { link1, link2 };
        }
    }
}
