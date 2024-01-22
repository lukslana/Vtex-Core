using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Order.Invoice.Response
{
    public class OrderInvoiceNotificationResponse : BaseResponse
    {
        public DateTime date { get; set; }
        public string orderId { get; set; }
        public string receipt { get; set; }
    }
}
