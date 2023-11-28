using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Common.Extensions;

namespace Vtex.Component.Entities.Catalog.SKU.Request
{
    public class GetSkuByAlternateIdRequest : BaseSkuRequest
    {
        internal protected override string BaseUrl => "api/catalog_system/pvt/sku/stockkeepingunitbyalternateId/{alternateId}";
        public override HttpMethod HttpMethod => HttpMethod.Get;

        /// <summary>
        /// Product EAN or RefId.
        /// </summary>
        public int AlternateId { get; set; }

        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();
            parameters.Add("alternateId", this.AlternateId.ToString());
            return parameters;
        }
    }
}
