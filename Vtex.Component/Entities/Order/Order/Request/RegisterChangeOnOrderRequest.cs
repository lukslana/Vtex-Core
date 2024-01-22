using Vtex.Component.Entities.Common.Extensions;
using Vtex.Component.Entities.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Order.Order.Request
{
    /// <summary>
    /// This request allows changing an order by:
    ///<br></br>Adding items to an order
    ///<br></br>
    ///<br></br>Removing items from an order
    ///<br></br>
    ///<br></br>Applying discounts to the total value of the order
    ///<br></br>
    ///<br></br>Incrementing the total value of the order.
    ///<br></br>
    ///<br></br>In those scenarios of order changes, it is possible to insert a Partial invoice. The total value of the order will be updated after the insertion of the invoice, even when there is a partial invoice scenario.The updated value is settled by VTEX's Payment Gateway. The reimbursement for the shopper is automatic.
    ///<br></br>
    ///<br></br>This action can only be done for orders in these status:
    ///<br></br>
    ///<br></br>handling
    ///<br></br>
    ///<br></br>waiting-for-fulfillment
    ///<br></br>
    ///<br></br>The Change order resource is needed to use this API request. This is included in OMS - Full access and IntegrationProfile - Fulfillment Oms, among other default roles available in the Admin. Learn more about the License manager roles and resources.
    /// </summary>
    public class RegisterChangeOnOrderRequest : BaseRequest
    {

        protected internal override string BaseUrl => "api/oms/pvt/orders/{orderId}/changes";

        public override HttpMethod HttpMethod => HttpMethod.Post;

        [JsonIgnore]
        public string orderId { get; set; }

        /// <summary>
        /// Request identification of the change. Only the first change made with each requestId will be effective on a given order. Use different IDs for different changes to the same order.
        /// </summary>
        public string requestId { get; set; }

        /// <summary>
        /// Reason for order change. This may be shown to the shopper in the UI or transactional emails.
        /// </summary>
        public string reason { get; set; }

        /// <summary>
        /// This field can be used to apply a discount to the total value of the order. Value in cents.
        /// </summary>
        public int discountValue { get; set; }

        /// <summary>
        /// This field can be used to increment the total value of the order. Value in cents.
        /// </summary>
        public int incrementValue { get; set; }

        /// <summary>
        /// List of items that should be removed from the order.
        /// </summary>
        public Itemsadded[] itemsAdded { get; set; }

        /// <summary>
        /// List of items that should be added to the order.
        /// </summary>
        public Itemsremoved[] itemsRemoved { get; set; }

        public class Itemsadded
        {
            /// <summary>
            /// Product ID of the item.
            /// </summary>
            public string id { get; set; }

            /// <summary>
            /// Price of the item in cents.
            /// </summary>
            public int quantity { get; set; }

            /// <summary>
            /// Amount of items to be removed.
            /// </summary>
            public int price { get; set; }
        }
        public class Itemsremoved
        {
            /// <summary>
            /// Product ID of the item.
            /// </summary>
            public string id { get; set; }

            /// <summary>
            /// Price of the item in cents.
            /// </summary>
            public int quantity { get; set; }

            /// <summary>
            /// Amount of items to be removed.
            /// </summary>
            public int price { get; set; }
        }

        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();
            parameters.Add("orderId", orderId.ToString());
            
            return parameters;
        }
    }
}
