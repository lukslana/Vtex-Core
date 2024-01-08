using Vtex.Component.Entities.Common.Extensions;
using Vtex.Component.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Checkout.ShoppingCart.Request
{
    public class GetCartInformationByIDRequest: BaseRequest, IRequestQueryString
    {
        public string orderFormId { get; set; }
        protected internal override string BaseUrl => "api/checkout/pub/orderForm/{orderFormId}?refreshOutdatedData=true";
   
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
