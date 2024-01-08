using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Common.Extensions;

namespace Vtex.Component.Entities.Catalog.Product.Request
{
    public class GetProductByRefIdRequest: BaseProductRequest
    {
        protected internal override string BaseUrl => "api/catalog_system/pvt/products/productgetbyrefid/{refId}";
        public string refId { get; set; }
        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();
            parameters.Add("refId", this.refId.ToString());
            return parameters;
        }

    }
}
