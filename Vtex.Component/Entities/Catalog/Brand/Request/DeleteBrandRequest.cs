using Vtex.Component.Entities.Common.Extensions;

namespace Vtex.Component.Entities.Catalog.Brand.Request
{
    public class DeleteBrandRequest: BaseCatalogRequest
    {
        protected internal override string BaseUrl => "/api/catalog/pvt/brand/{brandId}";

        public override HttpMethod HttpMethod => HttpMethod.Delete;

        /// <summary>
        /// Brand’s numerical identifier
        /// </summary>
        public virtual int brandId { get; set; }

        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();
            parameters.Add("brandId", this.brandId.ToString());
            return parameters;
        }
    }   
}
