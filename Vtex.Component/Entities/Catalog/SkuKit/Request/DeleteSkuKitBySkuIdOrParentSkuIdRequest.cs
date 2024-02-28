using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Common.Extensions;

namespace Vtex.Component.Entities.Catalog.SkuKit.Request
{

    public class DeleteSkuKitBySkuIdOrParentSkuIdRequest : BaseCatalogRequest
    {
        internal protected override string BaseUrl => "api/catalog/pvt/stockkeepingunitkit";
        public override HttpMethod HttpMethod => HttpMethod.Delete;

        /// <summary>
        /// SKU's unique numerical identifier.
        /// </summary>
        public int SkuId { get; set; }

        /// <summary>
        /// SKU's unique numerical identifier.
        /// </summary>
        public int ParentSkuId { get; set; }

        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();
            parameters.Add("skuId", this.SkuId.ToString());
            parameters.Add("parentSkuId", this.ParentSkuId.ToString());
            return parameters;
        }

    }
}
