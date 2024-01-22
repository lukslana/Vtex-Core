using Vtex.Component.Entities.Common.Extensions;
using Vtex.Component.Entities.Interfaces;
using Vtex.Component.Entities.Order.Common;
using Vtex.Component.Entities.Order.Extensions;


namespace Vtex.Component.Entities.Order.Invoice.Request
{

    public class OrderInvoiceNotificationRequest : BaseRequest
    {
        protected internal override string BaseUrl => "api/oms/pvt/orders/{orderId}/invoice";

        public override HttpMethod HttpMethod => HttpMethod.Get;

        /// <summary>
        /// Order ID
        /// </summary>
        public string orderId { get; set; }

        /// <summary>
        /// Order ID
        /// </summary>
        public Status status { get; set; }


        /// <summary>
        /// The type of invoice. There are two possible values: Output and Input. The Output type should be used when the invoice you are sending is a selling invoice. The Input type should be used when you send a return invoice.
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// Issuance date of the invoice. You must add date and time in this field.
        /// </summary>
        public DateTime issuanceDate { get; set; }

        /// <summary>
        /// Number that identifies the invoice.
        /// </summary>
        public string invoiceNumber { get; set; }

        /// <summary>
        /// Total amount being invoiced in cents. Do not use any decimal separator. For instance, $24.99 should be represented as 2499.
        /// </summary>
        public int invoiceValue { get; set; }

        /// <summary>
        /// URL of the invoice. Can be used to send the URL of an XML file, for example, which is useful for some integrations.
        /// </summary>
        public string invoiceUrl { get; set; }

        /// <summary>
        /// XML text of the invoice, not the URL. This field is very important for external marketplace integrations such as Mercado Libre.
        /// </summary>
        public string embeddedInvoice { get; set; }

        /// <summary>
        /// The name of the carrier responsible for delivering the order. This field should only be used when sending the tracking information. When the request is used for sending the invoice, this field should be left empty ("").
        /// </summary>
        public string courier { get; set; }

        /// <summary>
        /// The number code that identifies the order tracking. This field should only be used when sending the tracking information. When the request is used for sending the invoice, this field should be left empty ("").
        /// </summary>
        public string trackingNumber { get; set; }

        /// <summary>
        /// The URL used to track the order. This field should only be used when sending the tracking information. When the request is used for sending the invoice, this field should be left empty ("").
        /// </summary>
        public string trackingUrl { get; set; }

        /// <summary>
        /// Order dispatch date. May be null.
        /// </summary>
        public string dispatchedDate { get; set; }


        public List<Item> items { get; set; }

        public class Item
        {
            public string id { get; set; }
            public int quantity { get; set; }
            public int price { get; set; }
        }

        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();
            parameters.Add("orderId", orderId.ToString());
            return parameters;

        }
    }
}
