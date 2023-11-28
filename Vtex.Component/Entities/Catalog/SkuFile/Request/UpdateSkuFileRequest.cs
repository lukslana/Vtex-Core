
using Vtex.Component.Entities.Common.Extensions;

namespace Vtex.Component.Entities.Catalog.SkuFile.Request
{
    public class UpdateSkuFileRequest : BaseCatalogRequest
    {
        internal protected override string BaseUrl => "api/catalog/pvt/stockkeepingunit/{skuId}/file/{skuFileId}";
        public override HttpMethod HttpMethod => HttpMethod.Put;

        /// <summary>
        /// SKU’s unique numerical identifier.
        /// </summary>
        public int SkuId { get; set; }

        /// <summary>
        /// ID of the association of the SKU and the image, which can be obtained by placing a request to the Get SKU File endpoint and copying the Id field.
        /// </summary>
        public int SkuFileId { get; set; }

        /// <summary>
        /// Defines if the Image is the main image of the SKU.
        /// </summary>
        public bool IsMain { get; set; }

        /// <summary>
        /// SKU image label.
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// SKU image name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// General text of the image.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// External Image's URL. The URL must start with the protocol identifier (http:// or https://) and end with the file extension (.jpg, .png or .gif).
        /// </summary>
        public string Url { get; set; }
        
        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();
            parameters.Add("skuId", this.SkuId.ToString());
            parameters.Add("skuFileId", this.SkuFileId.ToString());
            return parameters;
        }
    }
}
