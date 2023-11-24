using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Common.Extensions;
using Vtex.Component.Entities.Interfaces;

namespace Vtex.Component.Entities.Catalog.ProductSpecification.Request
{
    public class UpdateProductSpecificationByProductIdRequest : BaseCatalogRequest
    {
        protected internal override string BaseUrl => "api/catalog_system/pvt/products/{productId}/specification";

        public override HttpMethod HttpMethod => HttpMethod.Post;

        /// <summary>
        /// Product’s unique identifier.
        /// </summary>
        [JsonIgnore]
        public int productId { get; set; }
        
        public Specification[] specifications { get; set; }
        public class Specification
        {
            public string[] Value { get; set; }
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            this.DataRequestBody = specifications;
            var parameters = base.GetQueryStringParameters();
            parameters.Add("productId", this.productId.ToString());
            return parameters;
        }
    }
}
