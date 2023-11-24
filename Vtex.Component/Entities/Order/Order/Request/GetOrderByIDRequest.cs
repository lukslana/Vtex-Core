using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Common.Extensions;
using Vtex.Component.Entities.Interfaces;

namespace Vtex.Component.Entities.Order.Order.Request
{
    /// <summary>
    /// The View order resource is needed to use this API request. 
    /// This is included in OMS - Full access and IntegrationProfile - Fulfillment Oms, 
    /// among other default roles available in the Admin. Learn more about the License manager roles and resources.
    /// </summary>
    public class GetOrderByIDRequest: BaseOrderRequest, IRequestQueryString
    {
        public virtual string orderId { get; set; }
        public override string BaseUrl => "api/oms/pvt/orders/{orderId}";


        public override IList<KeyValuePair<string, string>> GetQueryStringWithoutParameters()
        {
            var parameters = base.GetQueryStringWithoutParameters();

            if (!string.IsNullOrEmpty(this.orderId))
            {
                parameters.Add("orderId", this.orderId);
            }
            return parameters;
        }
    }
}
