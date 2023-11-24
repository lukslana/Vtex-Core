using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Common.Extensions;

namespace Vtex.Component.Entities.Catalog.SpecificationGroup.Request
{
    public  class GetSpecificationGroupRequest: BaseCatalogRequest
    {
        protected internal override string BaseUrl => "api/catalog_system/pub/specification/groupGet/{groupId}";

        public override HttpMethod HttpMethod => HttpMethod.Get;
        public int groupId { get; set; }

        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();
            parameters.Add("Id", this.groupId.ToString());
            return parameters;
        }
    }
}
