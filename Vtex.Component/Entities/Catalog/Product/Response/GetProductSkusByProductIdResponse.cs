using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Catalog.Product.Response
{
    public class GetProductSkusByProductIdResponse: BaseResponse
    {
        public int productId { get; set; }
        public string name { get; set; }
        public string salesChannel { get; set; }
        public bool available { get; set; }
        public string displayMode { get; set; }
        public object[] dimensions { get; set; }
        public Dimensionsinputtype dimensionsInputType { get; set; }
        public Dimensionsmap dimensionsMap { get; set; }
        public Sku[] skus { get; set; }
 

        public class Dimensionsinputtype
        {
        }

        public class Dimensionsmap
        {
        }

        public class Sku
        {
            public int? sku { get; set; }
            public string skuname { get; set; }
            public Dimensions dimensions { get; set; }
            public bool available { get; set; }
            public string availablequantity { get; set; }
            public object cacheVersionUsedToCallCheckout { get; set; }
            public string listPriceFormated { get; set; }
            public string listPrice { get; set; }
            public string taxFormated { get; set; }
            public string taxAsInt { get; set; }
            public string bestPriceFormated { get; set; }
            public string bestPrice { get; set; }
            public string spotPrice { get; set; }
            public string installments { get; set; }
            public string installmentsValue { get; set; }
            public object installmentsInsterestRate { get; set; }
            public string image { get; set; }
            public string sellerId { get; set; }
            public string seller { get; set; }
            public Measures measures { get; set; }
            public string unitMultiplier { get; set; }
            public string rewardValue { get; set; }
        }
        public class Dimensions
        {
        }
        public class Measures
        {
            public string cubicweight { get; set; }
            public string height { get; set; }
            public string length { get; set; }
            public string weight { get; set; }
            public string width { get; set; }
        }
    }
}
