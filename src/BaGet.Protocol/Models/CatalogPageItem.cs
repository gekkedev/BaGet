using System;
using Newtonsoft.Json;

namespace BaGet.Protocol
{
    /// <summary>
    /// An item in the <see cref="CatalogIndex"/> that references a <see cref="CatalogPage"/>.
    /// See: https://docs.microsoft.com/en-us/nuget/api/catalog-resource#catalog-page-object-in-the-index
    /// Based off: https://github.com/NuGet/NuGet.Services.Metadata/blob/64af0b59c5a79e0143f0808b39946df9f16cb2e7/src/NuGet.Protocol.Catalog/Models/CatalogPageItem.cs
    /// </summary>
    public class CatalogPageItem
    {
        /// <summary>
        /// The URL to this item's corresponding <see cref="CatalogPage"/>.
        /// </summary>
        [JsonProperty("@id")]
        public string CatalogPageUrl { get; set; }

        [JsonProperty("commitTimeStamp")]
        public DateTimeOffset CommitTimestamp { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }
}
