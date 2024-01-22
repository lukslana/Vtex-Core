using System;
using System.Collections.Generic;
using System.Linq;
using Vtex.Component.Entities.Common.Extensions;
using Vtex.Component.Entities.Interfaces;
using Vtex.Component.Entities.Order.Common;
using Vtex.Component.Entities.Order.Extensions;

namespace Vtex.Component.Entities.Order.Order.Request
{
    public class ListOrdersRequest : BaseRequest
    {
        protected internal override string BaseUrl => "api/oms/pvt/orders/";
        public override HttpMethod HttpMethod => HttpMethod.Get;

        /// <summary>
        /// Order Field and Order Type concatenated orderBy={{OrderField}},{{OrderType}}
        /// </summary>
        public OrderBy orderBy { get; set; }

        /// <summary>
        /// Page Number
        /// </summary>
        public string page { get; set; }

        /// <summary>
        /// Quantity orders per page
        /// </summary>
        public string per_page { get; set; }

        /// <summary>
        /// Time Zone
        /// </summary>
        public string utc { get; set; }

        /// <summary>
        /// Fulltext accepts Order Ids, Client E-mail, Client Document and Client Name
        /// </summary>
        public string q { get; set; }

        public int f_shippingEstimate { get; set; }

        /// <summary>
        /// Affiliate ID Value
        /// </summary>
        public string searchField { get; set; }

        /// <summary>
        /// Order Status Value
        /// </summary>
        public Status status { get; set; }

        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();

            if (this.orderBy > 0)
            {
                parameters.Add("orderBy", OrderByExtensions.OrderToString(this.orderBy));
            }

            if (!string.IsNullOrEmpty(this.page))
            {
                parameters.Add("page", this.page);
            }

            if (!string.IsNullOrEmpty(this.searchField))
            {
                parameters.Add("searchField", this.searchField);
            }

            if (!string.IsNullOrEmpty(this.per_page))
            {
                parameters.Add("per_page", this.per_page);
            }

            if (!string.IsNullOrEmpty(this.utc))
            {
                parameters.Add("utc", this.utc);
            }

            if (!string.IsNullOrEmpty(this.q))
            {
                parameters.Add("q", this.q);
            }

            if (this.f_shippingEstimate > 0)
            {
                parameters.Add("f_shippingEstimate", this.f_shippingEstimate + ".days");
            }

            if (this.status > 0)
            {
                parameters.Add("f_status", StatusExtensions.StatusToString(this.status));
            }
            return parameters;
        }
    }
}
