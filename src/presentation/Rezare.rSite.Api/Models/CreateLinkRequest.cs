using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rezare.rSite.Api.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateLinkRequest
    {
        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>
        /// The URI.
        /// </value>
        public string  Url { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the tag
        /// </summary>
        public string Tags { get; set; }
    }
}
