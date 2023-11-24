using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Common.Extensions;

namespace Vtex.Component.Entities.Catalog.ProductSpecification.Request
{
    public class AssociateProductSpecificationUsingSpecificationNameAndGroupNameRequest : BaseCatalogRequest
    {
        protected internal override string BaseUrl => "api/catalog/pvt/product/{productId}/specificationvalue";

        public override HttpMethod HttpMethod => HttpMethod.Put;

        /// <summary>
        /// Product’s unique identifier.
        /// </summary>
        [JsonIgnore]
        public int productId { get; set; }
        public string FieldName { get; set; }
        public string GroupName { get; set; }
        public bool RootLevelSpecification { get; set; }
        public string[] FieldValues { get; set; }

        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();
            parameters.Add("productId", this.productId.ToString());
            return parameters;
        }
    }
}
