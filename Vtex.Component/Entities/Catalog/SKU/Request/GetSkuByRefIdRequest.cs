using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Common.Extensions;
using Vtex.Component.Entities.Interfaces;

namespace Vtex.Component.Entities.Catalog.SKU.Request
{
    public class GetSkuByRefIdRequest : BaseSKURequest
    {
        internal protected override string BaseUrl => "/api/catalog/pvt/stockkeepingunit";
        public int RefId { get; set; }
        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();
            parameters.Add("refId", this.RefId.ToString());
            return parameters;
        }
    }
}
