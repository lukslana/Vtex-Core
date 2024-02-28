using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Catalog.SkuKit.Request
{
    public class GetSkuKitBySkuIdOrParentSkuIdRequest : BaseCatalogRequest
    {
        internal protected override string BaseUrl => "api/catalog/pvt/stockkeepingunitkit";
        public override HttpMethod HttpMethod => HttpMethod.Get;

        /// <summary>
        /// SKU's unique numerical identifier.
        /// </summary>
        public int SkuId { get; set; }

        /// <summary>
        /// SKU's unique numerical identifier.
        /// </summary>
        public int ParentSkuId { get; set; }
    }
}
