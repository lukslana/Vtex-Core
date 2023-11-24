using Vtex.Component.Entities.Common.Extensions;
using Vtex.Component.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Catalog.Category.Request
{
    public class GetCategoryByIdRequest : BaseCatalogRequest, IRequestQueryString
    {
        public override string BaseUrl => "api/catalog/pvt/category/{categoryId}";

        /// <summary>
        /// Category’s unique numerical identifier.
        /// </summary>
        public int categoryId { get; set; }

        public override IList<KeyValuePair<string, string>> GetQueryStringWithoutParameters()
        {
            var parameters = base.GetQueryStringParameters();
            parameters.Add("categoryId", this.categoryId.ToString());
            return parameters;
        }
    }
}
