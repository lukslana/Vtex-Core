using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Order.Common
{
    public enum Status
    {
         handling
        ,invoiced
        ,canceled
        ,waiting_for_sellers_confirmation
        ,payment_pending
        ,payment_approved
        ,payment_denied
        ,waiting_for_seller_decision
        ,waiting_ffmt_authorization
        ,authorize_fulfillment
        ,window_to_cancel
        ,ready_for_handling
        ,start_handling
        ,ship
        ,invoice
        ,request_cancel
        ,order_accepted
        ,shipped
        ,cancel
    }
}
