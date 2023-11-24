using Vtex.Component.Entities.Common.Extensions;
using Vtex.Component.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Catalog.SkuEan.Request
{
    public class CreateSkuEanRequest : BaseSKUEanRequest, IRequestJsonPost
    {
        public override string BaseUrl => "api/catalog/pvt/stockkeepingunit/{skuId}/ean/{ean}";

        /// <summary>
        /// SKU's unique numerical identifier.
        /// </summary>
        public int skuId { get; set; }

        /// <summary>
        /// EAN
        /// </summary>
        public string ean { get; set; }

        public override IList<KeyValuePair<string, string>> GetQueryStringWithoutParameters()
        {
            var parameters = base.GetQueryStringWithoutParameters();

            parameters.Add("skuId", this.skuId.ToString());
            parameters.Add("ean", this.ean.ToString());

            return parameters;
        }
    }
}
