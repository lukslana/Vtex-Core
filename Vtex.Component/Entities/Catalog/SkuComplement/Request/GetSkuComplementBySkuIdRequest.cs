using Vtex.Component.Entities.Common.Extensions;

namespace Vtex.Component.Entities.Catalog.SkuComplement.Request
{
    public class GetSkuComplementBySkuIdRequest: BaseCatalogRequest
    {
        protected internal override string BaseUrl => "api/catalog/pvt/stockkeepingunit/{skuId}/complement";
        public override HttpMethod HttpMethod => HttpMethod.Get;
        public int SkuId { get; set; }

        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();
            parameters.Add("skuId", this.SkuId.ToString());
            return parameters;
        }
    }
}
