using System;
using System.Collections.Generic;
using Rezare.rSite.Domain.ValueObjects;

namespace Rezare.rSite.Application.UseCases
{
    /// <summary>
    /// LinksProvider.
    /// </summary>
    public static class LinksProvider
    {
        /// <summary>
        /// Get Links.
        /// </summary>
        /// <returns>The list of Links.</returns>
        public static IEnumerable<Link> GetLinks()
        {
#pragma warning disable S1075
            var path1 = "https://www.2talk.co.nz/login.html";
            var path2 = "https://buildmaster.rezare.co.nz/";
#pragma warning restore S1075

            var link1 = new Link
            {
                Uri = new Uri(path1),
                Name = "2talk",
                Description = "The 2talk portal for managing your work phone."
            };

            var link2 = new Link
            {
                Uri = new Uri(path2),
                Name = "BuildMaster",
                Description = "Deployment system for Rezare projects."
            };

            return new[] { link1, link2 };
        }
    }
}
