using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Catalog.SpecificationValue.Request
{
    public class CreateSpecificationValueRequest : BaseCatalogRequest
    {
        protected internal override string BaseUrl => "api/catalog/pvt/specificationvalue";

        public override HttpMethod HttpMethod => HttpMethod.Post;
        public int FieldId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public int Position { get; set; }
    }
}
