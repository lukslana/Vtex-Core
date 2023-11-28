using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Common.Extensions;

namespace Vtex.Component.Entities.Catalog.SkuSpecification.Request
{
    public class UpdateSkuSpecificationRequest : BaseCatalogRequest
    {
        protected internal override string BaseUrl => "api/catalog/pvt/stockkeepingunit/{skuId}/specification";
        public override HttpMethod HttpMethod => HttpMethod.Put;

        /// <summary>
        /// Specification and SKU association unique identifier. This field cannot be updated.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// SKU’s unique numerical identifier.
        /// </summary>
        public int SkuId { get; set; }

        /// <summary>
        /// Specification field unique identifier. This field cannot be updated.
        /// </summary>
        public int FieldId { get; set; }

        /// <summary>
        /// Specification value unique identifier. This field can only be updated with other values of the same FieldId.
        /// </summary>
        public int FieldValueId { get; set; }

        /// <summary>
        /// Specification Value Name. This field is automatically updated if the FieldValue is updated. Otherwise, the value cannot be modified.
        /// </summary>
        public string Text { get; set; }

        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();
            parameters.Add("skuId", this.SkuId.ToString());
            return parameters;
        }
    }
}
