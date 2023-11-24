using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Common.Extensions;

namespace Vtex.Component.Entities.Catalog.SpecificationValue.Request
{
    public class UpdateSpecificationValueRequest : BaseCatalogRequest
    {
        protected internal override string BaseUrl => "api/catalog/pvt/specificationvalue/{SpecificationValueId}";
        public override HttpMethod HttpMethod => HttpMethod.Put;
        public int SpecificationValueId { get; set; }   
        public int FieldId { get; set; }
        public string Name { get; set; }
        public object Text { get; set; }
        public bool IsActive { get; set; }
        public int Position { get; set; }
    
        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();
            parameters.Add("SpecificationValueId", this.SpecificationValueId.ToString());
            return parameters;
        }
    }
}
