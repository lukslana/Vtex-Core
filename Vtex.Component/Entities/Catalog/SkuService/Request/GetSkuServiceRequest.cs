using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Common.Extensions;

namespace Vtex.Component.Entities.Catalog.SkuService.Request
{
    public class GetSkuServiceRequest : BaseSkuServiceRequest
    {
        internal protected override string BaseUrl => "api/catalog/pvt/skuservice/{skuServiceId}";
        public override HttpMethod HttpMethod => HttpMethod.Get;

        /// <summary>
        /// SKU service unique identifier.
        /// </summary>
        public int SkuServiceId { get; set; }

        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();
            parameters.Add("skuServiceId", this.SkuServiceId.ToString());
            return parameters;
        }
    }
}
