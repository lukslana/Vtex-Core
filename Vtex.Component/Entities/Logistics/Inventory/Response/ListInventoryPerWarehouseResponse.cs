using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Logistics.Inventory.Response
{
    public class ListInventoryPerWarehouseResponse : BaseLogisticsResponse
    {
        public Data[] data { get; set; }
        public class Data
        {
            public string skuId { get; set; }
            public string warehouseId { get; set; }
            public string dockId { get; set; }
            public int totalQuantity { get; set; }
            public int reservedQuantity { get; set; }
            public int availableQuantity { get; set; }
            public bool isUnlimited { get; set; }
            public string[] salesChannel { get; set; }
            public string[] deliveryChannels { get; set; }
            public object timeToRefill { get; set; }
            public object dateOfSupplyUtc { get; set; }
            public object supplyLotId { get; set; }
            public bool keepSellingAfterExpiration { get; set; }
            public object transfer { get; set; }
        }
    }
}
    

