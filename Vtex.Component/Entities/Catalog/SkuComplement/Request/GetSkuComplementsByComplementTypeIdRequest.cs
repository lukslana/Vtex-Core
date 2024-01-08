using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Common.Extensions;

namespace Vtex.Component.Entities.Catalog.SkuComplement.Request
{
    public class GetSkuComplementsByComplementTypeIdRequest: BaseCatalogRequest
    {
        protected internal override string BaseUrl => "api/catalog/pvt/stockkeepingunit/{skuId}/complement/{complementTypeId}";
        public override HttpMethod HttpMethod => HttpMethod.Get;
        public int SkuId { get; set; }
        public int ComplementTypeId { get; set; }

        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();
            parameters.Add("skuId", this.SkuId.ToString());
            parameters.Add("complementTypeId", this.ComplementTypeId.ToString());
            return parameters;
        }
    }
}
