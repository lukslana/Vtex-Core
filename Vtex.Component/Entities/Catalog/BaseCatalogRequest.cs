using System.Collections.Generic;

namespace Vtex.Component.Entities.Catalog
{
    public class BaseCatalogRequest : BaseRequest
    {
        protected internal override string BaseUrl => "";

        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();
            return parameters;
        }
    }
}
