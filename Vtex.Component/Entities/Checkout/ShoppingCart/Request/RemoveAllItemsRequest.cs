using System.Collections.Generic;
using Vtex.Component.Entities.Common.Extensions;
using Vtex.Component.Entities.Interfaces;

namespace Vtex.Component.Entities.Checkout.ShoppingCart.Request
{
    public class RemoveAllItemsRequest: BaseRequest
    {
        protected internal override string BaseUrl => "api/checkout/pub/orderForm/{orderFormId}/items/removeAll";
        public string orderFormId { get; set; }
        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();
            if (!string.IsNullOrEmpty(this.orderFormId))
            {
                parameters.Add("orderFormId", this.orderFormId);
            }
            return parameters;
        }
    }
}
