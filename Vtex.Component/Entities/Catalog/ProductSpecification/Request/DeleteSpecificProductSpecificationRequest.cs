using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Common.Extensions;

namespace Vtex.Component.Entities.Catalog.ProductSpecification.Request
{
    public class DeleteSpecificProductSpecificationRequest : BaseCatalogRequest
    {
        protected internal override string BaseUrl => "api/catalog/pvt/product/{productId}/specification/{specificationId}";

        public override HttpMethod HttpMethod => HttpMethod.Delete;

        /// <summary>
        /// Product’s unique identifier.
        /// </summary>
        [JsonIgnore]
        public int productId { get; set; }

        /// <summary>
        /// Product Specification’s unique numerical identifier.
        /// </summary>
        [JsonIgnore]
        public int specificationId { get; set; }

        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();
            parameters.Add("productId", this.productId.ToString());
            parameters.Add("specificationId", this.specificationId.ToString());
            return parameters;
        }
    }
}
