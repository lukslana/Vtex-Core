using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Order.Common;
using Vtex.Component.Entities.Interfaces;
using Vtex.Component.Entities.Order.Extensions;
using Vtex.Component.Entities.Common.Extensions;

namespace Vtex.Component.Entities.Order.Order.Request
{
    public class StartHandlingOrderRequest: BaseRequest
    {
        protected internal override string BaseUrl => "api/oms/pvt/orders/{orderId}/{status}";

        /// <summary>
        /// Order ID
        /// </summary>
        public string orderId { get; set; }
        public Status status { get; set; }

        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();

            parameters.Add("orderId", orderId.ToString());
            parameters.Add("status", StatusExtensions.StatusToString(Status.start_handling));

            return parameters;
        }
    }
}
