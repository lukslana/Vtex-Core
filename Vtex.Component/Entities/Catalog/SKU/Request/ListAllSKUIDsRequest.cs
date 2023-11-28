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
    public class ListAllSkuIdsRequest: BaseSkuRequest
    {
        protected internal override string BaseUrl => "api/catalog_system/pvt/sku/stockkeepingunitids";
        public override HttpMethod HttpMethod => HttpMethod.Get;

        /// <summary>
        /// Replace this variable with the result page number that you need retrieves SKU ID
        /// </summary>
        public string Page { get; set; }

        /// <summary>
        /// Replace this variable with the page size that you need retrieves SKU ID, maximum value 1000
        /// </summary>
        public string Pagesize { get; set; }

        /// <summary>
        /// Função ou URL que é executada quando algum evento acontece ou depois que algum código chega ao estado desejado
        /// </summary>
        public string CallbackURL { get; set; }

        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();

            if (!string.IsNullOrEmpty(this.Page.ToString()))
            {
                parameters.Add("page", this.Page);
            }

            if (!string.IsNullOrEmpty(this.Pagesize.ToString()))
            {
                parameters.Add("pagesize", this.Pagesize);
            }

            if (!string.IsNullOrEmpty(this.CallbackURL.ToString()))
            {
                parameters.Add("callbackURL", this.CallbackURL);
            }

            return parameters;
        }
    }
}
