using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Common.Extensions;

namespace Vtex.Component.Entities.Catalog.Product.Request
{
    /// <summary>
    /// Retrieves a specific product's general information as name, description and the trade policies that it is included.
    /// </summary>
    public class GetProductAndItsGeneralContextRequest: BaseProductRequest
    {
        public override string BaseUrl => "api/catalog_system/pvt/products/productget/{productId}";
        public string productId { get; set; }
        public override IList<KeyValuePair<string, string>> GetQueryStringWithoutParameters()
        {
            var parameters = base.GetQueryStringParameters();
            parameters.Add("productId", this.productId.ToString());
            return parameters;
        }
    }
}
