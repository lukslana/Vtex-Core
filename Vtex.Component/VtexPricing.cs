using Vtex.Component.Entities.Pricing.PricesAndFixedPrices.Request;
using Vtex.Component.Entities.Pricing.PricesAndFixedPrices.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component
{
    /*
    /// <summary>
    ///Pricing(v2) is the VTEX module responsible for the SKU's price list. 
    ///At this module we have the base price of each SKU, some optional fixed prices by trade policy, 
    ///and some rules that can be applied to generate dynamically different final prices according to the purchase context and the trade policy.
    /// </summary>
    public class VtexPricing
    {
        /// <summary>
        /// Retrieves price data given a specific SKU ID. Within the fixedPrices object, there might be a list of prices for specific Trade Policies and Minimium Quantities of the SKU. Fixed Prices may also be scheduled.
        /// </summary>
        public static HttpEngine<GetPriceRequest, GetPriceResponse> GetPrice => HttpEngine<GetPriceRequest, GetPriceResponse>.instance;

        /// <summary>
        /// Creates or updates an SKU Base Price or Fixed Prices. <br></br>
        /// The base price is the basic selling price of a product, it comprises the cost price and the markup wanted in the sale of the product.<br></br>
        /// The fixed price is an optional price of the SKU for a specific trade policy with a specific minimum quantity to be activated.
        /// </summary>
        public static HttpEngine<CreateOrUpdateBasePriceOrFixedPricesRequest, CreateOrUpdateBasePriceOrFixedPricesResponse> CreateOrUpdateBasePriceOrFixedPrices => HttpEngine<CreateOrUpdateBasePriceOrFixedPricesRequest, CreateOrUpdateBasePriceOrFixedPricesResponse>.instance;
    }
    */
}
