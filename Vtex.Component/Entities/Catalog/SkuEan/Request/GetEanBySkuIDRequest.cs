using Vtex.Component.Entities.Common.Extensions;
using Vtex.Component.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Catalog.SkuEan.Request
{
    public class GetEanBySkuIDRequest : BaseSKUEanRequest, IRequestQueryString
    {
        public override string BaseUrl => "api/catalog/pvt/stockkeepingunit/{skuId}/ean";

        /// <summary>
        /// EAN of the SKU which you need to retrieve details from.
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
