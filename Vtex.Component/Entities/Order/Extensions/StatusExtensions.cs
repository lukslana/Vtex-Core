using Vtex.Component.Entities.Order.Common;

namespace Vtex.Component.Entities.Order.Extensions
{
    public static class StatusExtensions
    {
        public static string StatusToString(this Status status)
        {
            switch (status)
            {
                case Status.payment_approved:
                    return "payment-approved";
                case Status.payment_pending:
                    return "payment-pending";
                case Status.handling:
                    return "handling";
                case Status.invoiced:
                    return "invoiced";
                case Status.canceled:
                    return "canceled";
                case Status.waiting_for_sellers_confirmation:
                    return "waiting-for-sellers_confirmation";
                case Status.payment_denied:
                    return "payment-denied";
                case Status.waiting_for_seller_decision:
                    return "waiting-for-seller-decision";
                case Status.waiting_ffmt_authorization:
                    return "waiting-ffmt-authorization";
                case Status.authorize_fulfillment:
                    return "authorize-fulfillment";
                case Status.window_to_cancel:
                    return "window-to-cancel";
                case Status.ready_for_handling:
                    return "ready-for-handling";
                case Status.start_handling:
                    return "start-handling";
                case Status.ship:
                    return "ship";
                case Status.invoice:
                    return "invoice";
                case Status.request_cancel:
                    return "request-cancel";
                case Status.order_accepted:
                    return "order-accepted";
                case Status.shipped:
                    return "shipped";
                case Status.cancel:
                    return "cancel";
                default:
                    return "";
            }
        }
    }
}
