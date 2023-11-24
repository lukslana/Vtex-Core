using Vtex.Component.Entities.Common.Extensions;

namespace Vtex.Component.Entities.Catalog.CategorySpecification.Request
{
    public class GetSpecificationsByCategoryIdRequest : BaseCatalogRequest
    {
        protected internal override string BaseUrl => "api/catalog_system/pub/specification/field/listByCategoryId/{CategoryId}";
        public virtual int CategoryId { get; set; }
        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();
            parameters.Add("categoryId", this.CategoryId.ToString());
            return parameters;
        }
    }
}
