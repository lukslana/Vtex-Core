using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Interfaces;

namespace Vtex.Component.Entities.Catalog.Brand.Request
{
    /// <summary>
    /// Retrieves all Brands registered in the store's Catalog.
    /// </summary>
    public class GetBrandListRequest : BaseCatalogRequest
    {
        protected internal override string BaseUrl => "api/catalog/pvt/category";

    }
}
