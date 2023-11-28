using Vtex.Component.Entities.Common.Extensions;

namespace Vtex.Component.Entities.Catalog.SkuFile.Request
{
    public class GetSkuFilesRequest : BaseSkuFileRequest
    {
        internal protected override string BaseUrl => "api/catalog/pvt/stockkeepingunit/{skuId}/file";
        public override HttpMethod HttpMethod => HttpMethod.Get;

        /// <summary>
        /// SKU's unique numerical identifier.
        /// </summary>
        public int SkuId { get; set; }
        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();
            parameters.Add("skuId", this.SkuId.ToString());
            return parameters;
        }
    }
}
