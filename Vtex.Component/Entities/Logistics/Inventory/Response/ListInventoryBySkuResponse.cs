using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Logistics.Inventory.Response
{
    public class ListInventoryBySkuResponse: BaseLogisticsResponse
    {
        public string skuId { get; set; }
        public Balance[] balance { get; set; }

        public class Balance
        {
            public string warehouseId { get; set; }
            public string warehouseName { get; set; }
            public int totalQuantity { get; set; }
            public int reservedQuantity { get; set; }
            public bool hasUnlimitedQuantity { get; set; }
        }

    }
}
