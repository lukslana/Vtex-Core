using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Order.Order.Response
{
    public class RegisterChangeOnOrderResponse: BaseResponse
    {
        public DateTime date { get; set; }
        public string orderId { get; set; }
        public string receipt { get; set; }
    }
}
