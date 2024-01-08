using Vtex.Component.Entities.Common.Extensions;
using Vtex.Component.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Order.Order.Request
{
    public class RetrievePaymentTransactionRequest : BaseRequest
    {
        public virtual string orderId { get; set; }
        protected internal override string BaseUrl => "api/oms/pvt/orders/{orderId}/payment-transaction";

        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();

            if (!string.IsNullOrEmpty(this.orderId))
            {
                parameters.Add("orderId", this.orderId);
            }
            return parameters;
        }
    }
}
