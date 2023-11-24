using Vtex.Component.Entities.Common.Extensions;
using Vtex.Component.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Logistics.Inventory.Request
{
    public class UpdateInventoryBySKUandWarehouseRequest : BaseLogisticsRequest, IRequestJsonPut
    {
        public override string BaseUrl => "api/logistics/pvt/inventory/skus/{skuId}/warehouses/{warehouseId}";

        [JsonIgnore]
        public int skuId { get; set; }

        [JsonIgnore]
        public string warehouseId { get; set; }

        /// <summary>
        /// true/false
        /// </summary>
        public bool unlimitedQuantity { get; set; }

        /// <summary>
        /// Defines the corresponding moment to the informed warehouse. It is useful due to the liberation of handling order reservations. If not sent or null, indicates that the registered date and time should be the same as that of when the request is sent.
        /// </summary>
        public string? dateUtcOnBalanceSystem { get; set; } = null;

        public int quantity { get; set; }

        public override IList<KeyValuePair<string, string>> GetQueryStringWithoutParameters()
        {
            var parameters = base.GetQueryStringWithoutParameters();

            if (!string.IsNullOrEmpty(this.skuId.ToString()))
            {
                parameters.Add("skuId", this.skuId.ToString());
            }

            if (!string.IsNullOrEmpty(this.warehouseId))
            {
                parameters.Add("warehouseId", this.warehouseId);
            }

            return parameters;
        }
    }
}
