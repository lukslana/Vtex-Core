using Vtex.Component.Entities.Common.Extensions;

namespace Vtex.Component.Entities.Catalog.SkuSpecification.Request
{
    public class AssociateSkuSpecificationRequest : BaseCatalogRequest
    {
        protected internal override string BaseUrl => "api/catalog/pvt/stockkeepingunit/{skuId}/specification";
        public override HttpMethod HttpMethod => HttpMethod.Post;

        /// <summary>
        /// SKU’s unique numerical identifier.
        /// </summary>
        public int SkuId { get; set; }

        /// <summary>
        /// Specification field ID.
        /// </summary>
        public int FieldId { get; set; }

        /// <summary>
        /// Specification Value ID. Required only for FieldTypeId as 5, 6 and 7.
        /// </summary>
        public int FieldValueId { get; set; }

        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();
            parameters.Add("skuId", this.SkuId.ToString());
            return parameters;
        }
    }
}
