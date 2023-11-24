using System.Collections.Generic;

namespace Vtex.Component.Entities.GiftCard
{
    /// <summary>
    /// The Gift Card is a payment method configured as a cash value associated to a client. It is used to grant a discount on the value of the order at the store.
    /// </summary>
    public class BaseGiftCardRequest : BaseRequest
    {
        
        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();
            return parameters;
        }
    }
}
