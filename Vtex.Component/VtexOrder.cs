using Vtex.Component.Entities.Order.Invoice.Request;
using Vtex.Component.Entities.Order.Invoice.Response;
using Vtex.Component.Entities.Order.Order.Request;
using Vtex.Component.Entities.Order.Order.Response;

namespace Vtex.Component
{
 
    /// <summary>
    /// Receive, process, and manage every order in your store through our Order Management API.
    /// </summary>
    public class VtexOrder
    {
        /*
        #region Order
        /// <summary>
        /// Retrieve order details by searching a specific order ID or sequence number.
        /// The View order resource is needed to use this API request. This is included in OMS - <br></br>
        /// Full access and IntegrationProfile - Fulfillment Oms, among other default roles available in the Admin. Learn more about the License manager roles and resources.
        /// </summary>
        public static HttpEngine<GetOrderByIDRequest, GetOrderByIDResponse> GetOrderByID => HttpEngine<GetOrderByIDRequest, GetOrderByIDResponse>.instance;

        /// <summary>
        /// Retrieve a list of orders according to the filters described below.
        /// </summary>
        public static HttpEngine<ListOrdersRequest, ListOrdersResponse> ListOrders => HttpEngine<ListOrdersRequest, ListOrdersResponse>.instance;

        /// <summary>
        /// Change the status of an order to indicate that is is in handling.<br></br>
        /// Expect a status 204 response with no content in case of a successful request. <br></br>
        /// The Change order workflow status resource is needed to use this API request. This is included in OMS - Full access and IntegrationProfile - Fulfillment Oms, among other default roles available in the Admin. Learn more about the License manager roles and resources. 
        /// </summary>
        public static HttpEngine<StartHandlingOrderRequest, StartHandlingOrderResponse> StartHandlingOrder => HttpEngine<StartHandlingOrderRequest, StartHandlingOrderResponse>.instance;


        /// <summary>
        ///This request allows changing an order by:
        ///<br></br>
        ///Adding items to an order
        ///<br></br>
        ///Removing items from an order
        ///<br></br>
        ///Applying discounts to the total value of the order
        ///<br></br>
        ///Incrementing the total value of the order.
        ///<br></br>
        ///In those scenarios of order changes, it is possible to insert a Partial invoice. The total value of the order will be updated after the insertion of the invoice, even when there is a partial invoice scenario.The updated value is settled by VTEX's Payment Gateway. The reimbursement for the shopper is automatic.
        ///<br></br>
        ///This action can only be done for orders in these status:
        /// </summary>
        public static HttpEngine<RegisterChangeOnOrderRequest, RegisterChangeOnOrderResponse> RegisterChangeOnOrder => HttpEngine<RegisterChangeOnOrderRequest, RegisterChangeOnOrderResponse>.instance;

        /// <summary>
        ///You should use this endpoint to cancel an order by its order identification number (the orderId).
        ///<br></br>
        ///A common scenario is one where the seller has a problem with the order fulfillment and needs to request the order cancellation to the marketplace.To do this, the seller would need to make this request, passing the orderId in the URL.
        ///<br></br>
        ///You should expect a response with the date when the notification was received, the orderId, and a receipt protocol code.
        ///<br></br>
        ///Be aware that if the order status is already Invoiced, the order can only be canceled if—before using this request—you send a return invoice through the Order Invoice Notification endpoint.
        ///<br></br>
        ///The Cancel order resource is needed to use this API request. This is included in OMS - Full access and IntegrationProfile - Fulfillment Oms, among other default roles available in the Admin. Learn more about the License manager roles and resources.
        /// </summary>
        public static HttpEngine<CancelOrderRequest, CancelOrderResponse> CancelOrder => HttpEngine<CancelOrderRequest, CancelOrderResponse>.instance;

        #endregion

        #region Invoice
        /// <summary>
        ///Entering the invoice in the order is a required step for its status to change to Invoiced - a sign that the order has been successfully completed.Remember that once an order is read as invoiced by the system, this status cannot be changed.
        ///<br></br><br></br>
        ///The total value of the order will be updated after the insertion of the invoice, even when there's a Partial invoice scenario. The updated value is settled by VTEX's Payment Gateway.The reimbursement for the shopper is automatic.
        ///<br></br><br></br>
        ///We strongly recommend that you always send the object of the invoiced items.With this practice, rounding errors will be avoided.
        ///<br></br><br></br>
        ///When returning items, an input invoice must be sent through this call.For that, the type field should be filled in with input.
        ///<br></br><br></br>
        ///It is not allowed to use the same invoiceNumber in more than one request to the Order Invoice Notification endpoint.
        ///<br></br><br></br>
        ///For marketplace integrations: once the order is invoiced, the seller should use this request to send the invoice information to the marketplace.Be aware that this endpoint is also used by the seller to send the order tracking information.This, however, should be done in a separate moment, once the seller has the tracking information.
        /// </summary>
        public static HttpEngine<OrderInvoiceNotificationRequest, OrderInvoiceNotificationResponse> OrderInvoiceNotification => HttpEngine<OrderInvoiceNotificationRequest, OrderInvoiceNotificationResponse>.instance;
        #endregion
        */

    }
    
}
