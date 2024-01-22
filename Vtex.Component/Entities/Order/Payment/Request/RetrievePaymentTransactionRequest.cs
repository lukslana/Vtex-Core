using Vtex.Component.Entities.Common.Extensions;

namespace Vtex.Component.Entities.Order.Payment.Request
{
    public class RetrievePaymentTransactionRequest : BaseRequest
    {
        public virtual string orderId { get; set; }
        protected internal override string BaseUrl => "api/oms/pvt/orders/{orderId}/payment-transaction";

        public override HttpMethod HttpMethod => HttpMethod.Get;
        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();

            if (!string.IsNullOrEmpty(orderId))
            {
                parameters.Add("orderId", orderId);
            }
            return parameters;
        }
    }
}
