using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Common.Extensions;

namespace Vtex.Component.Entities.Catalog.SpecificationValue.Request
{
    public class GetSpecificationValueRequest : BaseCatalogRequest
    {
        protected internal override string BaseUrl => "api/catalog/pvt/specificationvalue/{specificationValueId}";

        public override HttpMethod HttpMethod => HttpMethod.Get;

        public int specificationValueId { get; set; }
        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();
            parameters.Add("specificationValueId", this.specificationValueId.ToString());
            return parameters;
        }
    }
}
