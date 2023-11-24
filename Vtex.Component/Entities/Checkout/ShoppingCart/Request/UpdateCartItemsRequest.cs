using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Common.Extensions;
using Vtex.Component.Entities.Interfaces;

namespace Vtex.Component.Entities.Checkout.ShoppingCart.Request
{
    public class UpdateCartItemsRequest: BaseRequest, IRequestJsonPatch
    {
        public override string BaseUrl => "api/checkout/pub/orderForm/{orderFormId}/items";
        /// <summary>
        /// ID of the orderForm corresponding to the cart whose items you want to update.
        /// </summary>
        public string orderFormId { get; set; }

        /// <summary>
        /// Array containing the cart items. Each object inside this array corresponds to a different item.
        /// </summary>
        public List<orderItems> orderItems { get; set; }   
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

    /// <summary>
    /// Array containing the cart items. Each object inside this array corresponds to a different item.
    /// </summary>
    public class orderItems
    {
        /// <summary>
        /// The quantity of the item the cart.
        /// </summary>
        public int quantity { get; set; }

        /// <summary>
        /// The seller responsible for the SKU.
        /// </summary>
        public string seller { get; set; }

        /// <summary>
        /// The ID of the SKU in VTEX platform.
        /// </summary>
        public string id { get; set; }
    }
}
