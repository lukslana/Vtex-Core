using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Common.Extensions;

namespace Vtex.Component.Entities.Catalog.SpecificationField.Request
{
    public class GetSpecificationFieldRequest: BaseCatalogRequest
    {
        protected internal override string BaseUrl => "api/catalog_system/pub/specification/fieldGet/{fieldId}";

        public override HttpMethod HttpMethod => HttpMethod.Get;
        public int fieldId { get; set; }    



        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();
            parameters.Add("fieldId", this.fieldId.ToString());
            return parameters;
        }
    }
}
