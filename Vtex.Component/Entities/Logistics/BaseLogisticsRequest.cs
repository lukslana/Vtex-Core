using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Logistics
{
    public class BaseLogisticsRequest: BaseRequest
    {
        protected internal override string BaseUrl => "api/logistics/pvt/inventory";
        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();

            return parameters;
        }

    }
}
