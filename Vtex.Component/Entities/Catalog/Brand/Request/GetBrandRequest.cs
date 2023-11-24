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
    public class GetBrandRequest : BaseCatalogRequest, IRequestQueryString
    {
        protected internal override string BaseUrl => "api/catalog_system/pvt/brand/{brandId}";

        /// <summary>
        /// Brand ID.
        /// </summary>
        public int brandId { get; set; }

        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();
            parameters.Add("brandId", this.brandId.ToString());
            return parameters;
        }
    }
}
