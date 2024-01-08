using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Interfaces;

namespace Vtex.Component.Entities.Catalog.Product
{
    public class BaseProductRequest : BaseCatalogRequest
    {
        protected internal override string BaseUrl => "api/catalog_system/pvt/products/";

        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();

            return parameters;
        }

    }
}
