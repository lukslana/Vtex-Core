using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Logistics.Inventory.Request;
using Vtex.Component.Entities.Logistics.Inventory.Response;

namespace Vtex.Component
{
    /// <summary>
    /// The Logistics API gives you access to your store's warehouses, docks, pick up points, carriers <br></br>
    /// and shipping rates and allows you to update the inventory of each SKU and manage fulfillment data.  <br></br>
    /// You can also receive, process, and manage every order through our APIs.
    /// </summary>
    public class VtexLogistics
    {
        /// <summary>
        /// Lists your store's inventory by SKU ID
        /// </summary>
        public static HttpEngine<ListInventoryBySkuRequest, ListInventoryBySkuResponse> ListInventoryBySku => HttpEngine<ListInventoryBySkuRequest, ListInventoryBySkuResponse>.instance;

        /// <summary>
        /// Lists inventory information per warehouse on your store.
        /// </summary>
        public static HttpEngine<ListInventoryPerWarehouseRequest, ListInventoryPerWarehouseResponse> ListInventoryPerWarehouse => HttpEngine<ListInventoryPerWarehouseRequest, ListInventoryPerWarehouseResponse>.instance;

        /// <summary>
        /// Updates inventory for a given SKU and warehouse.
        /// </summary>
        public static HttpEngine<UpdateInventoryBySKUandWarehouseRequest, UpdateInventoryBySKUandWarehouseResponse> UpdateInventoryBySKUandWarehouse => HttpEngine<UpdateInventoryBySKUandWarehouseRequest, UpdateInventoryBySKUandWarehouseResponse>.instance;
    }
}
