using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Vtex.Component.Entities.Common.Extensions;

namespace Vtex.Component.Entities.Catalog.ProductSpecification.Request
{
    public class AssociateProductSpecificationRequest : BaseCatalogRequest
    {
        protected internal override string BaseUrl => "api/catalog/pvt/product/{productId}/specification";

        public override HttpMethod HttpMethod => HttpMethod.Post;

        /// <summary>
        /// Product’s unique identifier.
        /// </summary>
        [JsonIgnore]
        public int productId { get; set; }

        /// <summary>
        /// Specification field ID.
        /// </summary>
        public int FieldId { get; set; }

        /// <summary>
        /// Specification Value ID. Mandatory for FieldTypeId 5, 6 and 7. Must not be used for any other field types
        /// </summary>
        public int FieldValueId { get; set; }

        /// <summary>
        /// Specification Value ID. Mandatory for FieldTypeId 5, 6 and 7. Must not be used for any other field types
        /// </summary>
        public string Text { get; set; }

        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();
            parameters.Add("productId", this.productId.ToString());
            return parameters;
        }
    }
}
