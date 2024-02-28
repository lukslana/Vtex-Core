using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Common.Extensions;

namespace Vtex.Component.Entities.Catalog.SkuKit.Request
{
    public class GetSkuKitRequest : BaseCatalogRequest
    {
        internal protected override string BaseUrl => "api/catalog/pvt/stockkeepingunitkit/{kitId}";
        public override HttpMethod HttpMethod => HttpMethod.Get;

        /// <summary>
        /// Kit's unique numerical identifier
        /// </summary>
        public int KitId { get; set; }

        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();
            parameters.Add("kitId", this.KitId.ToString());
            return parameters;
        }
    }
}
