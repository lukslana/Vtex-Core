using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Common.Extensions;

namespace Vtex.Component.Entities.Catalog.SkuFile.Request
{
    public class DisassociateSkuFileRequest : BaseSkuFileRequest
    {
        internal protected override string BaseUrl => "api/catalog/pvt/stockkeepingunit/disassociate/{skuId}/file/{skuFileId}";
        public override HttpMethod HttpMethod => HttpMethod.Delete;

        /// <summary>
        /// SKU's unique numerical identifier.
        /// </summary>
        public int SkuId { get; set; }

        /// <summary>
        /// ID of the association of the SKU and the image, which can be obtained by placing a request to the Get SKU File endpoint and copying the Id field.
        /// </summary>
        public int SkuFileId { get; set; }
        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();
            parameters.Add("skuId", this.SkuId.ToString());
            parameters.Add("skuFileId", this.SkuFileId.ToString());
            return parameters;
        }
    }
}
