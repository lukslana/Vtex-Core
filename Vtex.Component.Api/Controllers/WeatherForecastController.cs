using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Linq.Expressions;
using Vtex.Component.Entities.Catalog.Brand.Request;
using Vtex.Component.Entities.Catalog.CategorySpecification.Request;
using Vtex.Component.Entities.Catalog.CategorySpecification.Response;
using Vtex.Component.Entities.Catalog.SKU.Request;
using Vtex.Component.Entities.Catalog.SKU.Response;
using Vtex.Component.Entities.Search.Search.Request;
using Vtex.Component.Interfaces.Catalog.Brand;
using Vtex.Component.Interfaces.Catalog.CategorySpecification;

namespace Vtex.Component.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private IGetBrandList _getBrandList;
		private IGetSpecificationsByCategoryId _getSpecificationsByCategoryId;

		private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly VtexApi _vtexApi;


        public WeatherForecastController(IOptions<VtexApi> vtexApi, ILogger<WeatherForecastController> logger, IGetBrandList getBrandList, IGetSpecificationsByCategoryId getSpecificationsByCategoryId)
        {
            _logger = logger;
            _vtexApi = vtexApi.Value;
			_getBrandList = getBrandList;
			_getSpecificationsByCategoryId = getSpecificationsByCategoryId;
		}

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<GetSpecificationsByCategoryIdResponse> GetAsync(int CategoryId)
        {
			IEnumerable<WeatherForecast> weatherForecasts = new List<WeatherForecast>();
            GetSpecificationsByCategoryIdResponse getSpecificationsByCategoryIdResponse = new GetSpecificationsByCategoryIdResponse();

			try
            {
				GetSpecificationsByCategoryIdRequest getSpecificationsByCategoryId = new GetSpecificationsByCategoryIdRequest
				{
                    AccountName = _vtexApi.AppAccountName,
                    Environment = _vtexApi.AppEnvironment,
                    AppKey = _vtexApi.AppKey,
                    AppToken = _vtexApi.AppToken,
                    CategoryId = CategoryId
				};
				getSpecificationsByCategoryIdResponse = await _getSpecificationsByCategoryId.QueryAsync(getSpecificationsByCategoryId);
			}
            catch (Exception)
            {

                throw;
            }
            return getSpecificationsByCategoryIdResponse;
		}
    }
}
