using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Common.Extensions;

namespace Vtex.Component.Entities.Catalog.SkuSpecification.Request
{
    public class GetSkuSpecificationsRequest : BaseCatalogRequest
    {
        protected internal override string BaseUrl => "api/catalog/pvt/stockkeepingunit/{skuId}/specification";
        public override HttpMethod HttpMethod => HttpMethod.Get;

        /// <summary>
        /// SKU’s unique numerical identifier.
        /// </summary>
        public int SkuId { get; set; }

        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();
            parameters.Add("skuId", this.SkuId.ToString());
            return parameters;
        }
    }
}
