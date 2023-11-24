using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Order.Order.Response
{
    public class ListOrdersResponse : BaseOrderResponse
    {
        public List[] list { get; set; }
        public object[] facets { get; set; }
        public Paging paging { get; set; }
        
        //public Stats stats { get; set; }

        public class Paging
        {
            public int total { get; set; }
            public int pages { get; set; }
            public int currentPage { get; set; }
            public int perPage { get; set; }
        }

        public class Stats
        {
            public Stats1 stats { get; set; }
        }

        public class Stats1
        {
            public Totalvalue totalValue { get; set; }
            public Totalitems totalItems { get; set; }
        }

        public class Totalvalue
        {
            public float Count { get; set; }
            public float Max { get; set; }
            public float Mean { get; set; }
            public float Min { get; set; }
            public float Missing { get; set; }
            public float StdDev { get; set; }
            public float Sum { get; set; }
            public long SumOfSquares { get; set; }
            public Facets Facets { get; set; }
        }

        public class Facets
        {
            public Origin origin { get; set; }
            public Currencycode currencyCode { get; set; }
        }

        public class Origin
        {
            public Fulfillment Fulfillment { get; set; }
            public Marketplace Marketplace { get; set; }
        }

        public class Fulfillment
        {
            public float Count { get; set; }
            public float Max { get; set; }
            public float Mean { get; set; }
            public float Min { get; set; }
            public float Missing { get; set; }
            public float StdDev { get; set; }
            public float Sum { get; set; }
            public float SumOfSquares { get; set; }
            public object Facets { get; set; }
        }

        public class Marketplace
        {
            public float Count { get; set; }
            public float Max { get; set; }
            public float Mean { get; set; }
            public float Min { get; set; }
            public float Missing { get; set; }
            public float StdDev { get; set; }
            public float Sum { get; set; }
            public long SumOfSquares { get; set; }
            public object Facets { get; set; }
        }

        public class Currencycode
        {
            public BRL BRL { get; set; }
        }

        public class BRL
        {
            public float Count { get; set; }
            public float Max { get; set; }
            public float Mean { get; set; }
            public string Min { get; set; }
            public string Missing { get; set; }
            public float StdDev { get; set; }
            public string Sum { get; set; }
            public long SumOfSquares { get; set; }
            public object Facets { get; set; }
        }

        public class Totalitems
        {
            public float Count { get; set; }
            public float Max { get; set; }
            public float Mean { get; set; }
            public float Min { get; set; }
            public float Missing { get; set; }
            public float StdDev { get; set; }
            public string Sum { get; set; }
            public string SumOfSquares { get; set; }
            public Facets1 Facets { get; set; }
        }

        public class Facets1
        {
            public Origin1 origin { get; set; }
            public Currencycode1 currencyCode { get; set; }
        }

        public class Origin1
        {
            public Fulfillment1 Fulfillment { get; set; }
            public Marketplace1 Marketplace { get; set; }
        }

        public class Fulfillment1
        {
            public float Count { get; set; }
            public float Max { get; set; }
            public float Mean { get; set; }
            public float Min { get; set; }
            public float Missing { get; set; }
            public float StdDev { get; set; }
            public float Sum { get; set; }
            public float SumOfSquares { get; set; }
            public object Facets { get; set; }
        }

        public class Marketplace1
        {
            public string Count { get; set; }
            public float Max { get; set; }
            public float Mean { get; set; }
            public string Min { get; set; }
            public string Missing { get; set; }
            public float StdDev { get; set; }
            public string Sum { get; set; }
            public string SumOfSquares { get; set; }
            public object Facets { get; set; }
        }

        public class Currencycode1
        {
            public BRL1 BRL { get; set; }
        }

        public class BRL1
        {
            public int Count { get; set; }
            public float Max { get; set; }
            public float Mean { get; set; }
            public int Min { get; set; }
            public int Missing { get; set; }
            public float StdDev { get; set; }
            public int Sum { get; set; }
            public int SumOfSquares { get; set; }
            public object Facets { get; set; }
        }

        public class List
        {
            public string orderId { get; set; }
           //public DateTime creationDate { get; set; }
           //public string clientName { get; set; }
           //public object items { get; set; }
           //public float totalValue { get; set; }
           //public string paymentNames { get; set; }
           //public string status { get; set; }
           //public string statusDescription { get; set; }
           //public string marketPlaceOrderId { get; set; }
           //public string sequence { get; set; }
           //public string salesChannel { get; set; }
           //public string affiliateId { get; set; }
           //public string origin { get; set; }
           //public bool workflowInErrorState { get; set; }
           //public bool workflowInRetry { get; set; }
           //public string lastMessageUnread { get; set; }
           //public DateTime? ShippingEstimatedDate { get; set; }
           //public object ShippingEstimatedDateMax { get; set; }
           //public object ShippingEstimatedDateMin { get; set; }
           //public bool orderIsComplete { get; set; }
           //public object listId { get; set; }
           //public object listType { get; set; }
           //public DateTime? authorizedDate { get; set; }
           //public object callCenterOperatorName { get; set; }
           //public string totalItems { get; set; }
           //public string currencyCode { get; set; }
        }
    }
}
