using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Order.Invoice.Response
{
    public class OrderInvoiceNotificationResponse : BaseResponse
    {
        public string invoiceValue { get; set; }
        public DateTime dispatchedDate { get; set; }
    }
}
