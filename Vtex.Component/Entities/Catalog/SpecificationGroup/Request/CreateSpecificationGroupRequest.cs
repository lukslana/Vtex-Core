using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Catalog.SpecificationGroup.Request
{
    public class CreateSpecificationGroupRequest : BaseRequest
    {

        protected internal override string BaseUrl => "api/catalog/pvt/specificationgroup";

        public override HttpMethod HttpMethod => HttpMethod.Post;
        public int CategoryId { get; set; }
        public string Name { get; set; }
    }
}
