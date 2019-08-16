using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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
        /// 
        /// </summary>
        /// <param name="link"></param>
        public Task<string> Create(Link link)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the links.
        /// </summary>
        /// <returns>
        /// The links.
        /// </returns>
        public Task<IEnumerable<Link>> GetLinks()
        {
#pragma warning disable S1075
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
#pragma warning restore S1075

            var list = new List<Link>
            {
                link1,
                link2,
                link3,
                link4,
                link5,
                link6,
                link7
            };
            return Task.FromResult<IEnumerable<Link>>(list);

            //return new[]
            //{
            //    link1,
            //    link2,
            //    link3,
            //    link4,
            //    link5,
            //    link6,
            //    link7
            //};
        }
    }
}
