using System.Threading;
using System.Threading.Tasks;

namespace BaGet.Protocol
{
    /// <summary>
    /// The resource used to search for packages.
    /// See: https://docs.microsoft.com/en-us/nuget/api/search-query-service-resource
    /// </summary>
    public interface ISearchResource
    {
        /// <summary>
        /// Perform a search query.
        /// See: https://docs.microsoft.com/en-us/nuget/api/search-query-service-resource#search-for-packages
        /// </summary>
        /// <param name="query">The search query.</param>
        /// <param name="skip">How many results to skip.</param>
        /// <param name="take">How many results to return.</param>
        /// <param name="includePrerelease">Whether pre-release packages should be returned.</param>
        /// <param name="includeSemVer2">Whether packages that require SemVer 2.0.0 compatibility should be returned.</param>
        /// <param name="cancellationToken">A token to cancel the task.</param>
        /// <returns>The search response.</returns>
        Task<SearchResponse> SearchAsync(
            string query,
            int skip = 0,
            int take = 20,
            bool includePrerelease = true,
            bool includeSemVer2 = true,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Perform an autocomplete query.
        /// See: https://docs.microsoft.com/en-us/nuget/api/search-autocomplete-service-resource
        /// </summary>
        /// <param name="query">The autocomplete query.</param>
        /// <param name="type">The autocomplete request type.</param>
        /// <param name="skip">How many results to skip.</param>
        /// <param name="take">How many results to return.</param>
        /// <param name="includePrerelease">Whether pre-release packages should be returned.</param>
        /// <param name="includeSemVer2">Whether packages that require SemVer 2.0.0 compatibility should be returned.</param>
        /// <param name="cancellationToken">A token to cancel the task.</param>
        /// <returns>The autocomplete response.</returns>
        Task<AutocompleteResponse> AutocompleteAsync(
            string query,
            AutocompleteType type = AutocompleteType.PackageIds,
            int skip = 0,
            int take = 20,
            bool includePrerelease = true,
            bool includeSemVer2 = true,
            CancellationToken cancellationToken = default);
    }
}
