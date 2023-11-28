using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Common.Extensions;

namespace Vtex.Component.Entities.Catalog.SKU.Request
{
    public class GetSkuListByProductIdRequest : BaseSkuRequest
    {
        internal protected override string BaseUrl => "api/catalog_system/pvt/sku/stockkeepingunitByProductId/{productId}";
        public override HttpMethod HttpMethod => HttpMethod.Get;

        /// <summary>
        /// Product’s unique numerical identifier.
        /// </summary>
        public int ProductId { get; set; }

        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();
            parameters.Add("productId", this.ProductId.ToString());
            return parameters;
        }
    }
}
