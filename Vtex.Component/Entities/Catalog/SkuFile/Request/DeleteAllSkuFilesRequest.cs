using Vtex.Component.Entities.Common.Extensions;
using Vtex.Component.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Catalog.SkuFile.Request
{
    public class DeleteAllSkuFilesRequest : BaseSkuFileRequest, IRequestJsonDelete
    {
        public override string BaseUrl => "api/catalog/pvt/stockkeepingunit/{skuId}/file";

        [JsonIgnore]
        /// <summary>
        /// SKU's unique numerical identifier.
        /// </summary>
        public int skuId { get; set; }

        public override IList<KeyValuePair<string, string>> GetQueryStringWithoutParameters()
        {
            var parameters = base.GetQueryStringWithoutParameters();

            parameters.Add("skuId", this.skuId.ToString());

            return parameters;
        }
    }
}
