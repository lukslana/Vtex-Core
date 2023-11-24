using System.Collections.Generic;
using Vtex.Component.Entities.Common.Extensions;
using Vtex.Component.Entities.Interfaces;

namespace Vtex.Component.Entities.Checkout.ShoppingCart.Request
{
    public class RemoveAllItemsRequest: BaseRequest, IRequestJsonPost
    {
        public override string BaseUrl => "api/checkout/pub/orderForm/{orderFormId}/items/removeAll";
        public string orderFormId { get; set; }
        public override IList<KeyValuePair<string, string>> GetQueryStringWithoutParameters()
        {
            var parameters = base.GetQueryStringWithoutParameters();
            if (!string.IsNullOrEmpty(this.orderFormId))
            {
                parameters.Add("orderFormId", this.orderFormId);
            }
            return parameters;
        }
    }
}
