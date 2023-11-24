using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Common.Extensions;
using Vtex.Component.Entities.Interfaces;

namespace Vtex.Component.Entities.Catalog.ProductSpecification.Request
{
    public class GetProductSpecificationByProductIdRequest : BaseCatalogRequest
    {
        protected internal override string BaseUrl => "api/catalog_system/pvt/products/{productId}/specification/";
        public override HttpMethod HttpMethod => HttpMethod.Get;
        public int productId { get; set; }
        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();
            parameters.Add("productId", this.productId.ToString());
            return parameters;
        }
    }
}
