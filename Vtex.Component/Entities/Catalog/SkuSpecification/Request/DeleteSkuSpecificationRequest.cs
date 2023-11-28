using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Common.Extensions;

namespace Vtex.Component.Entities.Catalog.SkuSpecification.Request
{
    public class DeleteSkuSpecificationRequest : BaseCatalogRequest
    {
        protected internal override string BaseUrl => "api/catalog/pvt/stockkeepingunit/{skuId}/specification/{specificationId}";
        public override HttpMethod HttpMethod => HttpMethod.Delete;

        /// <summary>
        /// SKU’s unique numerical identifier.
        /// </summary>
        public int SkuId { get; set; }

        /// <summary>
        /// Specification’s unique numerical identifier.
        /// </summary>
        public int SpecificationId { get; set; }

        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();
            parameters.Add("skuId", this.SkuId.ToString());
            parameters.Add("specificationId", this.SpecificationId.ToString());
            return parameters;
        }
    }
}
