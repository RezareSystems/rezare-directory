using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Rezare.rSite.Api.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/links")]
    [ApiController]
    public class LinksController : ControllerBase
    {
        /// <summary>
        /// Gets a bunch of links.
        /// </summary>
        /// <remarks>
        /// https://docs.microsoft.com/en-us/aspnet/core/web-api/action-return-types?view=aspnetcore-2.2
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
        /// 
        /// </summary>
        public class Link
        {
            /// <summary>
            /// 
            /// </summary>
            public Uri Uri { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public string Name { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public string Description { get; set; }
        }

        //// GET api/values/5
        //[HttpGet("{id}")]
        //public ActionResult<string> Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
