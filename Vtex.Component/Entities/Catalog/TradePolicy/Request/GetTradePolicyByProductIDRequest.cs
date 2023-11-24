using Vtex.Component.Entities.Common.Extensions;
using Vtex.Component.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Catalog.TradePolicy.Request
{
    public class GetTradePolicyByProductIDRequest : BaseTradePolicyRequest, IRequestJson
    {
        public override string BaseUrl => "api/catalog/pvt/product/{productId}/salespolicy";

        /// <summary>
        /// Product’s unique numerical identifier.
        /// </summary>
        public int productId { get; set; }

        public override IList<KeyValuePair<string, string>> GetQueryStringWithoutParameters()
        {
            var parameters = base.GetQueryStringWithoutParameters();

            parameters.Add("productId", this.productId.ToString());

            return parameters;
        }
    }
}
