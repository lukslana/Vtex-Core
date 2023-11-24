using System.Collections.Generic;
using Vtex.Component.Entities.Common.Extensions;

namespace Vtex.Component.Entities.Logistics.Inventory.Request
{
    public class ListInventoryPerWarehouseRequest: BaseLogisticsRequest
    {
        public override string BaseUrl => "api/logistics/pvt/inventory/items/{skuId}/warehouses/{warehouseId}";
        public string skuId { get; set; }
        public string warehouseId { get; set; }

        public override IList<KeyValuePair<string, string>> GetQueryStringWithoutParameters()
        {
            var parameters = base.GetQueryStringWithoutParameters();

            if (!string.IsNullOrEmpty(this.skuId))
            {
                parameters.Add("skuId", this.skuId);
            }

            if (!string.IsNullOrEmpty(this.warehouseId))
            {
                parameters.Add("warehouseId", this.warehouseId);
            }

            return parameters;
        }
    }
}
