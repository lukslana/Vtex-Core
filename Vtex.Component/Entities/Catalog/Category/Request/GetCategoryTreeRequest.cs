using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Common.Extensions;

namespace Vtex.Component.Entities.Catalog.Category.Request
{
    public class GetCategoryTreeRequest: BaseCatalogRequest
    {
        protected internal override string BaseUrl => "api/catalog_system/pub/category/tree/{categoryLevels}";
        public virtual int categoryLevels { get; set; }
        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();
            parameters.Add("categoryLevels", this.categoryLevels.ToString());
            return parameters;
        }
    }
}
