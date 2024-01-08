using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Common.Extensions;
using Vtex.Component.Entities.Interfaces;

namespace Vtex.Component.Entities.GiftCard.GiftCard.Request
{
    /// <summary>
    /// The View order resource is needed to use this API request. 
    /// This is included in OMS - Full access and IntegrationProfile - Fulfillment Oms, 
    /// among other default roles available in the Admin. Learn more about the License manager roles and resources.
    /// </summary>
    public class GetGiftCardbyIDRequest : BaseRequest
    {
        protected internal override string BaseUrl => "api/giftcards/{giftCardID}";
        public virtual string giftCardID { get; set; }
        
        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();

            if (!string.IsNullOrEmpty(this.giftCardID))
            {
                parameters.Add("giftCardID", this.giftCardID);
            }
            return parameters;
        }
    }
}
