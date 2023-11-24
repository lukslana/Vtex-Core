using Vtex.Component.Entities.Common.Extensions;

namespace Vtex.Component.Entities.Catalog.CategorySpecification.Request
{
    public class GetSpecificationsTreeByCategoryIdRequest: BaseCatalogRequest
    {
        public override HttpMethod HttpMethod => HttpMethod.Get;
        protected internal override string BaseUrl => "api/catalog_system/pub/specification/field/listTreeByCategoryId/{categoryId}";
        /// <summary>
        /// Category ID
        /// </summary>
        public int categoryId { get; set; }

        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();
            parameters.Add("categoryId", this.categoryId.ToString());
            return parameters;
        }

    }
}
