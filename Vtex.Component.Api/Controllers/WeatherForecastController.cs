using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Linq.Expressions;
using Vtex.Component.Entities.Catalog.SKU.Request;
using Vtex.Component.Entities.Catalog.SKU.Response;
using Vtex.Component.Entities.Search.Search.Request;

namespace Vtex.Component.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
       
        
 
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly VtexApi _vtexApi;

        public WeatherForecastController(IOptions<VtexApi> vtexApi, ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
            _vtexApi = vtexApi.Value;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<IEnumerable<WeatherForecast>> GetAsync()
        {
            int cod_skuId = 1001;
            GetSKUResponse getSKUResponse = new GetSKUResponse();
            try
            {

                var searchForProductsWithFilterRequest = new SearchForProductsWithFilterRequest
                {
                    appKey = _vtexApi.AppKey,
                    appToken = _vtexApi.AppToken,
                    accountName = _vtexApi.AppAccountName,
                    ft = "aptamil 1",
                    _from = 0,
                    _to = 49
                };
                var searchForProductsWithFilterResponse = await VtexSearch.SearchForProductsWithFilter.QueryAsync(searchForProductsWithFilterRequest);


            }
            catch (Exception)
            {
            }
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }).ToArray();
        }
    }
}
