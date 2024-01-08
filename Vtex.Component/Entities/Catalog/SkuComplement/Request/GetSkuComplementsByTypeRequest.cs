using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Catalog.SkuComplement.Request
{
    public class GetSkuComplementsByTypeRequest: BaseCatalogRequest
    {
        protected internal override string BaseUrl => "api/catalog_system/pvt/sku/complements/{parentSkuId}/{type}";
        public override HttpMethod HttpMethod => HttpMethod.Get;
        /// <summary>
        /// ID of the Parent SKU, where the Complement is inserted.
        /// </summary>
        public int ParentSkuId { get; set; }
        /// <summary>
        /// Complement Type ID. This represents the type of the complement. The possible values are: 1 for Accessory; 2 for Suggestion; 3 for Similar Product; 5 for Show Together.
        /// </summary>
        public int Type { get; set; }

        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();
            parameters.Add("skuId", this.SkuId.ToString());
            return parameters;
        }
    }
}
