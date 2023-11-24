using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Checkout.ShoppingCart.Request;
using Vtex.Component.Entities.Common.Extensions;
using Vtex.Component.Entities.Interfaces;

namespace Vtex.Component.Entities.Checkout.CustomData.Request
{
    public class SetMultipleCustomFieldValuesRequest: BaseRequest, IRequestJsonPut
    {
        public override string BaseUrl => "api/checkout/pub/orderForm/{orderFormId}/customData/{appId}";

        /// <summary>
        /// ID of the orderForm that will receive the new custom field values.
        /// </summary>
        public string orderFormId { get; set; }

        /// <summary>
        /// ID of the app created with the configuration API.
        /// </summary>
        public string appId { get; set; }

        public List<Dictionary<string, string>> custom { get; set; }

        public override IList<KeyValuePair<string, string>> GetQueryStringWithoutParameters()
        {
            var parameters = base.GetQueryStringWithoutParameters();
            if (!string.IsNullOrEmpty(this.orderFormId))
            {
                parameters.Add("orderFormId", this.orderFormId);
            }

            if (!string.IsNullOrEmpty(this.appId))
            {
                parameters.Add("appId", this.appId);
            }
            return parameters;
        }

    }
}
