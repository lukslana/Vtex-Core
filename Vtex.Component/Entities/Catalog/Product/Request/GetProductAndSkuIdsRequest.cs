using System.Collections.Generic;
using Vtex.Component.Entities.Common.Extensions;
using Vtex.Component.Entities.Interfaces;

namespace Vtex.Component.Entities.Catalog.Product.Request
{
    public class GetProductAndSkuIdsRequest: BaseProductRequest, IRequestQueryString
    {
        protected internal override string BaseUrl => "api/catalog_system/pvt/products/GetProductAndSkuIds";

        /// <summary>
        /// ID of the category from which you need to retrieve Products and SKUs.
        /// </summary>
        public string categoryId { get; set; }

        /// <summary>
        /// Insert the ID that will start the request result.
        /// </summary>
        public string _from { get; set; }

        /// <summary>
        /// Insert the ID that will end the request result.
        /// </summary>
        public string _to { get; set; }

        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();

            if (this._from != null)
            {
                parameters.Add("_from", this._from.ToString());
            }
            if (this._to != null)
            {
                parameters.Add("_to", this._to.ToString());
            }
            if (this.categoryId != null)
            {
                parameters.Add("categoryId", this.categoryId.ToString());
            }
            return parameters;
        }
    }
}
