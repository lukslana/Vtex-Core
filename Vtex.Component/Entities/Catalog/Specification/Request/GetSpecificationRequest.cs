using Vtex.Component.Entities.Common.Extensions;

namespace Vtex.Component.Entities.Catalog.Specification.Request
{
    public class GetSpecificationRequest: BaseCatalogRequest
    {
        protected internal override string BaseUrl => "api/catalog/pvt/specification/{specificationId}";
        public override HttpMethod HttpMethod => HttpMethod.Get;
        public int specificationId { get; set; }
        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();
            parameters.Add("specificationId", this.specificationId.ToString());
            return parameters;
        }
    }
}
