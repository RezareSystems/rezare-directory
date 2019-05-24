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

        /// <inheritdoc />
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Uri;
        }
    }
}
