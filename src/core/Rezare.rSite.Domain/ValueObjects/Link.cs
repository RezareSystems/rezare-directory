using System;
using System.Collections.Generic;
using Rezare.rSite.Domain.SeedWork;

namespace Rezare.rSite.Domain.ValueObjects
{
    /// <summary>
    /// Link.
    /// </summary>
    public class Link : ValueObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Link"/> class.
        /// </summary>
        /// <param name="uri">The link location.</param>
        /// <param name="name">The link's name.</param>
        /// <param name="description">The description of what this link is for.</param>
        public Link(Uri uri, string name, string description)
        {
            Uri = uri;
            Name = name;
            Description = description;
        }

        /// <summary>
        /// Gets the link value.
        /// </summary>
        public Uri Uri { get; }

        /// <summary>
        /// Gets the name of this link.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the link's description.
        /// </summary>
        public string Description { get; }

        /// <inheritdoc />
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Uri;
        }
    }
}
