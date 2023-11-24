using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Pricing.PricesAndFixedPrices.Response
{
    public class CreateOrUpdateBasePriceOrFixedPricesResponse: BaseResponse
    {
        public class GetPriceResponse : BaseResponse
        {
            public string itemId { get; set; }
            public decimal listPrice { get; set; }
            public decimal costPrice { get; set; }
            public decimal markup { get; set; }
            public int basePrice { get; set; }
            public Fixedprice[] fixedPrices { get; set; }
        }

        public class Fixedprice
        {
            public string tradePolicyId { get; set; }
            public decimal value { get; set; }
            public decimal listPrice { get; set; }
            public int minQuantity { get; set; }
            public Daterange dateRange { get; set; }
        }

        public class Daterange
        {
            public DateTime from { get; set; }
            public DateTime to { get; set; }
        }
    }

}
