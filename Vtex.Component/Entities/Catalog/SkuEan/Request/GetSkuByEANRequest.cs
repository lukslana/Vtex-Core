using Vtex.Component.Entities.Common.Extensions;
using Vtex.Component.Entities.Interfaces;

namespace Vtex.Component.Entities.Catalog.SkuEan.Request
{

    public class GetSkuByEANRequest : BaseSKUEanRequest, IRequestQueryString
    {
        public override string BaseUrl => "api/catalog_system/pvt/sku/stockkeepingunitbyean/{ean}";

        /// <summary>
        /// EAN of the SKU which you need to retrieve details from.
        /// </summary>
        public string ean { get; set; }

        public override IList<KeyValuePair<string, string>> GetQueryStringWithoutParameters()
        {
            var parameters = base.GetQueryStringWithoutParameters();

            parameters.Add("ean", this.ean.ToString());

            return parameters;
        }
    }
}
