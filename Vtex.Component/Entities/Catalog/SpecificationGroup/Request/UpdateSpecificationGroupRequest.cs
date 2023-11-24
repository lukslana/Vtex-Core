using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Common.Extensions;

namespace Vtex.Component.Entities.Catalog.SpecificationGroup.Request
{
    public class UpdateSpecificationGroupRequest: BaseRequest
    {

        protected internal override string BaseUrl => "api/catalog/pvt/specificationgroup/{groupId}";

        public override HttpMethod HttpMethod => HttpMethod.Put;
        public int groupId { get; set; }
        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();
            parameters.Add("groupId", this.groupId.ToString());
            return parameters;
        }
    }
}
