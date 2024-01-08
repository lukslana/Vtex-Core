using System.Net.Http;
using Vtex.Component.Entities.Catalog.CategorySpecification.Request;
using Vtex.Component.Interfaces;
using Vtex.Component.Interfaces.Catalog.Brand;
using Vtex.Component.Interfaces.Catalog.CategorySpecification;
using Vtex.Component.Interfaces.Search.Search;

namespace Vtex.Component.Api
{
	/// <summary>
	/// Service Collection Extensions.
	/// </summary>
	public static class ServiceCollectionExtensions
	{
		/// <summary>
		/// Adds the <see cref="HttpEngine{TRequest,TResponse}"/> and
		/// related services to the <see cref="IServiceCollection"/> and configures a named <see cref="HttpClient"/>.
		/// </summary>
		/// <param name="services">The <see cref="IServiceCollection"/>.</param>
		/// <param name="useHttpClientHandler">Whether to use the <see cref="HttpMessageHandler"/> on the <see cref="HttpClient"/>.</param>
		/// <returns>The <see cref="IServiceCollection"/>..</returns>
		public static IServiceCollection AddVtexApiClients(this IServiceCollection services, bool useHttpClientHandler = true)
		{
			if (services == null)
				throw new ArgumentNullException(nameof(services));

			services
				.AddHttpClient(nameof(VtexApi), HttpClientFactory.ConfigureDefaultHttpClient);

			services
				.AddApi<IGetBrandList, VtexCatalog.Brand.GetBrandListApi>(useHttpClientHandler);
			services
				.AddApi<IGetSpecificationsByCategoryId, VtexCatalog.CategorySpecification.GetSpecificationsByCategoryIdApi>(useHttpClientHandler);

			services.
				AddApi<ISearchForProductsWithFilter, VtexSearch.SearchForProductsWithFilter>(useHttpClientHandler);


			return services;
		}

		private static IServiceCollection AddApi<TService, TClient>(this IServiceCollection services, bool useHttpClientHandler = true)
			where TClient : class, TService
			where TService : class
		{
			var httpClientBuilder = services
				.AddHttpClient<TClient>(HttpClientFactory.ConfigureDefaultHttpClient);

			if (useHttpClientHandler)
			{
				httpClientBuilder
					.ConfigurePrimaryHttpMessageHandler(() => HttpClientFactory.GetDefaultHttpClientHandler(HttpClientFactory.Proxy))
					.SetHandlerLifetime(TimeSpan.FromMinutes(5));
			}

			services
				.AddTransient<TService, TClient>();

			return services;
		}
	}
}
