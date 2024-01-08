using Vtex.Component.Entities.Search.Search.Request;
using Vtex.Component.Entities.Search.Search.Response;
using Vtex.Component.Interfaces.Search.Search;

namespace Vtex.Component
{

	///<summary>
	///Check the new Search onboarding guide.We created this guide to improve the onboarding experience for developers at VTEX.
	///It assembles all documentation on our Developer Portal about Search and is organized by focusing on the developer's journey.
	/// </summary>
	public static partial class VtexSearch
	{
		/// <summary>
		/// Retrieves general information about the products related to the term searched.
		/// </summary>
		public static SearchForProductsRequestApi SearchForProducts => new();
		public sealed class SearchForProductsRequestApi : HttpEngine<SearchForProductsRequest, SearchForProductsResponse>, ISearchForProducts
		{
			public SearchForProductsRequestApi()
			{
			}
			public SearchForProductsRequestApi(HttpClient httpClient)
			: base(httpClient)
			{
			}
		}

		/// <summary>
		/// Retrives general information about the store products. This information can be filtered and ordered by a number of options. It also can be pagineted, filtered and ordered.
		/// </summary>
		public static SearchForProductsWithFilterApi SearchForProductsWithFilter => new();
		public sealed class SearchForProductsWithFilterApi : HttpEngine<SearchForProductsWithFilterRequest, SearchForProductsWithFilterResponse>, ISearchForProductsWithFilter
		{
			public SearchForProductsWithFilterApi()
			{
			}
			public SearchForProductsWithFilterApi(HttpClient httpClient)
			: base(httpClient)
			{
			}
		}
	}

}
