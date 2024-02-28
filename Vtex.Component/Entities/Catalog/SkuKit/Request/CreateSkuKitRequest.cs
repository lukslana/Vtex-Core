using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Catalog.SkuKit.Request
{
    public class CreateSkuKitRequest : BaseCatalogRequest
    {
        internal protected override string BaseUrl => "api/catalog/pvt/stockkeepingunitkit";
        public override HttpMethod HttpMethod => HttpMethod.Get;

        /// <summary>
        /// SKU ID of the SKU kit.
        /// </summary>
        public int StockKeepingUnitParent { get; set; }

        /// <summary>
        /// Component SKU ID.
        /// </summary>
        public int StockKeepingUnitId { get; set; }

        /// <summary>
        /// Component quantity.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Component price per unit.
        /// </summary>
        public float UnitPrice { get; set; }
     


    }
}
