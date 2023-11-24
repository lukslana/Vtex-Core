using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Common.Extensions;

namespace Vtex.Component.Entities.Catalog.SpecificationGroup.Request
{
    public class ListSpecificationGroupByCategoryRequest: BaseCatalogRequest
    {

        protected internal override string BaseUrl => "api/catalog_system/pvt/specification/groupbycategory/{categoryId}";

        public override HttpMethod HttpMethod => HttpMethod.Get;

        public int categoryId { get; set; }

        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();
            parameters.Add("BrandId", this.categoryId.ToString());
            return parameters;
        }
    }
}
