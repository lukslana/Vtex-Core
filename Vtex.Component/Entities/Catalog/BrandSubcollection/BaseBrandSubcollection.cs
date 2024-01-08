using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Catalog.BrandSubcollection
{
    public class BaseBrandSubcollection : BaseCatalogRequest
    {
        public override string BaseUr => base.BaseUrl + "api/catalog/pvt/subcollection/";
        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();

            return parameters;
        }

    }
}
