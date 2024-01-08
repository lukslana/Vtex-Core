using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Interfaces;

namespace Vtex.Component.Entities.Checkout.ShoppingCart.Request
{
    public class GetCurrentCartOrCreateNewOneRequest: BaseRequest, IRequestQueryString
    {
        protected internal override string BaseUrl => "api/checkout/pub/orderForm";
    }
}
