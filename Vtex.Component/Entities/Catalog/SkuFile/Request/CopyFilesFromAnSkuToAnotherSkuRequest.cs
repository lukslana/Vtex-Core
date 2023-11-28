using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Common.Extensions;

namespace Vtex.Component.Entities.Catalog.SkuFile.Request
{
    public class CopyFilesFromAnSkuToAnotherSkuRequest : BaseSkuFileRequest
    {
        internal protected override string BaseUrl => "api/catalog/pvt/stockkeepingunit/copy/{skuIdfrom}/{skuIdto}/file/";
        public override HttpMethod HttpMethod => HttpMethod.Put;

        /// <summary>
        /// Origin SKU’s unique numerical identifier.
        /// </summary>
        public int SkuIdfrom { get; set; }

        /// <summary>
        /// Target SKU’s unique numerical identifier.
        /// </summary>
        public int SkuIdto { get; set; }

        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();
            parameters.Add("skuIdfrom", this.SkuIdfrom.ToString());
            parameters.Add("skuIdto", this.SkuIdto.ToString());
            return parameters;
        }
    }
}
