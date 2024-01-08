using Vtex.Component.Entities.Common.Extensions;
using Vtex.Component.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Pricing.PricesAndFixedPrices.Request
{
    /// <summary>
    /// Retrieves price data given a specific SKU ID. Within the fixedPrices object, there might be a list of prices for specific Trade Policies and Minimium Quantities of the SKU. Fixed Prices may also be scheduled.
    /// </summary>
    public class GetPriceRequest : BaseRequest
    {
        protected internal override string BaseUrl => "pricing/prices/{itemId}";

        /// <summary>
        /// SKU ID.
        /// </summary>
        public int itemId { get; set; }

        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();
            parameters.Add("itemId", this.itemId.ToString());
            return parameters;
        }
    }
}
