using Vtex.Component.Entities.Common.Extensions;
using Vtex.Component.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Catalog.Brand.Request
{
    public class GetBrandAndContextRequest: BaseCatalogRequest, IRequestJson
    {
        protected internal override string BaseUrl => "api/catalog/pvt/brand/{brandId}";

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
