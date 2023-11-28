using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Catalog.SKU.Request
{
    public class RetrieveSkuIdListByReferenceIdListRequest : BaseSkuRequest
    {
        protected internal override string BaseUrl => "api/catalog_system/pub/sku/stockkeepingunitidsbyrefids";
        public override HttpMethod HttpMethod => HttpMethod.Post;
        public string[] ReferenceIdList { get; set; }
    }
}
