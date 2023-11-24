using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Common.Extensions;

namespace Vtex.Component.Entities.Catalog.SpecificationFieldValue.Request
{
    internal class GetSpecificationFieldValueRequest: BaseCatalogRequest
    {

        protected internal override string BaseUrl => "api/catalog_system/pvt/specification/fieldValue/{FieldValueId}";

        public override HttpMethod HttpMethod => HttpMethod.Get;
        public int FieldValueId { get; set; }    

        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();
            parameters.Add("FieldValueId", this.FieldValueId.ToString());
            return parameters;
        }
    }
}
