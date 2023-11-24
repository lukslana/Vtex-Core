using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Common.Extensions;
using Vtex.Component.Entities.Interfaces;

namespace Vtex.Component.Entities.Checkout.CartAttachments.Request
{
    public class AddMarketingDataRequest : BaseRequest, IRequestJsonPost
    {
        public override string BaseUrl => "api/checkout/pub/orderForm/{orderFormId}/attachments/marketingData";

        /// <summary>
        /// ID of the orderForm that will receive the new custom field values.
        /// </summary>
        public string orderFormId { get; set; }

        public string[] marketingTags { get; set; }

        public override IList<KeyValuePair<string, string>> GetQueryStringWithoutParameters()
        {
            var parameters = base.GetQueryStringWithoutParameters();
            if (!string.IsNullOrEmpty(this.orderFormId))
            {
                parameters.Add("orderFormId", this.orderFormId);
            }
            return parameters;
        }
    }
}
