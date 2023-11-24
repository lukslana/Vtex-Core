using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Common.Extensions;
using Vtex.Component.Entities.Interfaces;

namespace Vtex.Component.Entities.Catalog.SKU.Request
{
    public class GetSKURequest : BaseSKURequest, IRequestQueryString
    {
        public override string BaseUrl => "api/catalog/pvt/stockkeepingunit/{skuId}";
        public int skuId { get; set; }

        public override IList<KeyValuePair<string, string>> GetQueryStringWithoutParameters()
        {
            var parameters = base.GetQueryStringWithoutParameters();

            parameters.Add("skuId", this.skuId.ToString());

            return parameters;
        }
    }
}
