using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Common.Extensions;
using Vtex.Component.Entities.Interfaces;

namespace Vtex.Component.Entities.Catalog.SKU.Request
{
    public class GetSkuAndContextRequest: BaseSkuRequest
    {
        internal protected override string BaseUrl => "api/catalog_system/pvt/sku/stockkeepingunitbyid/{skuId}";
        public override HttpMethod HttpMethod => HttpMethod.Get;
        public int SkuId { get; set; }
        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();
            parameters.Add("skuId", this.SkuId.ToString());
            return parameters;
        }
    }
}
