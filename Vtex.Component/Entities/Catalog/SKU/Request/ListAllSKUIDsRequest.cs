using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Common.Extensions;
using Vtex.Component.Entities.Interfaces;

namespace Vtex.Component.Entities.Catalog.SKU.Request
{
    /// <summary>
    /// Retrieves the IDs of all SKUs in the store. Presents the result with page size and pagination.
    /// </summary>
    public class ListAllSKUIDsRequest: BaseSKURequest, IRequestQueryString
    {
        public override string BaseUrl => "api/catalog_system/pvt/sku/stockkeepingunitids";
        /// <summary>
        /// Replace this variable with the result page number that you need retrieves SKU ID
        /// </summary>
        public string page { get; set; }

        /// <summary>
        /// Replace this variable with the page size that you need retrieves SKU ID, maximum value 1000
        /// </summary>
        public string pagesize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string callbackURL { get; set; }

        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();

            if (!string.IsNullOrEmpty(this.page.ToString()))
            {
                parameters.Add("page", this.page);
            }

            if (!string.IsNullOrEmpty(this.pagesize.ToString()))
            {
                parameters.Add("pagesize", this.pagesize);
            }

            if (!string.IsNullOrEmpty(this.callbackURL.ToString()))
            {
                parameters.Add("callbackURL", this.callbackURL);
            }

            return parameters;
        }
    }
}
