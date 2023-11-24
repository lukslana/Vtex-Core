using Vtex.Component.Entities.Common.Extensions;
using Vtex.Component.Entities.Interfaces;

namespace Vtex.Component.Entities.Search.Search.Request
{
    public class SearchForProductsRequest: BaseSearchRequest, IRequestQueryString
    {
        public override string BaseUrl => "api/catalog_system/pub/products/search/{search}";

        /// <summary>
        /// Term used to search products
        /// </summary>
        public string search { get; set; }

        public override IList<KeyValuePair<string, string>> GetQueryStringWithoutParameters()
        {
            var parameters = base.GetQueryStringParameters();
            parameters.Add("search", this.search.ToString());
            return parameters;
        }
    }
}
