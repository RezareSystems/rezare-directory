using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Rezare.rSite.Api.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/links")]
    [ApiController]
    public class LinksProviderController : ControllerBase
    {
        /// <summary>
        /// Gets a bunch of links.
        /// </summary>
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

        public class Link
        {
            public Uri Uri { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
