using Vtex.Component.Entities.Common.Extensions;
using Vtex.Component.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Order.Order.Request
{
    /// <summary>
    ///You should use this endpoint to cancel an order by its order identification number (the orderId).
    ///<br></br>
    ///A common scenario is one where the seller has a problem with the order fulfillment and needs to request the order cancellation to the marketplace.To do this, the seller would need to make this request, passing the orderId in the URL.
    ///<br></br>
    ///You should expect a response with the date when the notification was received, the orderId, and a receipt protocol code.
    ///<br></br>
    ///Be aware that if the order status is already Invoiced, the order can only be canceled if—before using this request—you send a return invoice through the Order Invoice Notification endpoint.
    ///<br></br>
    ///The Cancel order resource is needed to use this API request. This is included in OMS - Full access and IntegrationProfile - Fulfillment Oms, among other default roles available in the Admin. Learn more about the License manager roles and resources.
    /// </summary>
    public class CancelOrderRequest : BaseOrderRequest, IRequestJsonPost
    {
        public override string BaseUrl => "api/oms/pvt/orders/{orderId}/cancel";

        /// <summary>
        /// Order ID
        /// </summary>
        public int orderId { get; set; }

        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();

            if (this.orderId > 0)
            {
                parameters.Add("orderId", orderId.ToString());
            }
            return parameters;
        }
    }
}
