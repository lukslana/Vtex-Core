using Vtex.Component.Entities.Common.Extensions;
using Vtex.Component.Entities.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Pricing.PricesAndFixedPrices.Request
{
    /// <summary>
    /// Creates or updates an SKU Base Price or Fixed Prices. 
    /// The base price is the basic selling price of a product, it comprises the cost price and the markup wanted in the sale of the product.
    /// The fixed price is an optional price of the SKU for a specific trade policy with a specific minimum quantity to be activated.
    /// </summary>
    public class CreateOrUpdateBasePriceOrFixedPricesRequest : BaseRequest
    {
        protected internal override string BaseUrl => "pricing/prices/{itemId}";

        [JsonIgnore]
        /// <summary>
        /// SKU ID.
        /// </summary>
        public int itemId { get; set; }

        public decimal listPrice { get; set; }
        public decimal costPrice { get; set; }
        public object markup { get; set; }
        public decimal basePrice { get; set; }
        public Fixedprice[] fixedPrices { get; set; }

        public class Fixedprice
        {
            public string tradePolicyId { get; set; }
            public decimal value { get; set; }
            public decimal listPrice { get; set; }
            public int minQuantity { get; set; }
            public Daterange dateRange { get; set; }
        }

        public class Daterange
        {
            public DateTime from { get; set; }
            public DateTime to { get; set; }
        }
        /*
        public override bool BaseUrlVtexIo => true;

        /// <summary>
        /// SKU ID.
        /// </summary>
        public int itemId { get; set; }

        /// <summary>
        /// The profit percentage that is to be obtained from the sale of that SKU. If you decide to fill the markup item, you must also fill the costPrice. 
        /// The basePrice will be automatically generated based on both values.
        /// </summary>
        public int? markup { get; set; }

        /// <summary>
        /// SKU's suggested selling price.
        /// </summary>
        public decimal basePrice { get; set; }

        /// <summary>
        /// SKU selling base price. 
        /// If you decide to fill only the basePrice item, the markup and costPrice will be automatically generated to adapt to the number inserted in basePrice.
        /// </summary>
        public decimal listPrice { get; set; }


        /// <summary>
        /// SKU selling cost price. 
        /// If you decide to fill the costPrice item, you must also fill the markup and basePrice will be automatically generated based on both values.
        /// </summary>
        public decimal costPrice { get; set; }
 
        public Fixedprice[] fixedPrices { get; set; }

        public class Fixedprice
        {
            public string tradePolicyId { get; set; }
            public decimal value { get; set; }
            public decimal listPrice { get; set; }
            public int minQuantity { get; set; }
            public Daterange dateRange { get; set; }
        }

        public class Daterange
        {
            public DateTime from { get; set; }
            public DateTime to { get; set; }
        }
        */
        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();
            parameters.Add("itemId", this.itemId.ToString());
            return parameters;
        }
    }
}
