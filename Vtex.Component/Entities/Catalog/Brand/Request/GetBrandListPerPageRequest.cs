using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Common.Extensions;
using Vtex.Component.Entities.Interfaces;

namespace Vtex.Component.Entities.Catalog.Brand.Request
{
    /// <summary>
    /// Retrieves all Brands registered in the store's Catalog.
    /// </summary>
    public class GetBrandListPerPageRequest : BaseCatalogRequest, IRequestQueryString
    {
        protected internal override string BaseUrl => "api/catalog_system/pvt/brand/pagedlist";

        /// <summary>
        /// Quantity of brands per page.
        /// </summary>
        public int pageSize { get; set; }

        /// <summary>
        /// Page number of the brand list.
        /// </summary>
        public int page { get; set; }

        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();
            parameters.Add("pageSize",  this.pageSize.ToString());
            parameters.Add("page",      this.page.ToString());
            return parameters;
        }
    }
}
