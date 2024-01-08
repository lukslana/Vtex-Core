using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Common.Extensions;

namespace Vtex.Component.Entities.Logistics.Inventory.Request
{
    public class ListInventoryBySkuRequest: BaseLogisticsRequest
    {
        protected internal override string BaseUrl => "api/logistics/pvt/inventory/skus/{skuId}";
        public string skuId { get; set; }

        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();

            if (!string.IsNullOrEmpty(this.skuId))
            {
                parameters.Add("skuId", this.skuId);
            }
            return parameters;
        }
    }
}
