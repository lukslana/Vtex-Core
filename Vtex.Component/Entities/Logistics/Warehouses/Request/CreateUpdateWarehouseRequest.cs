using Vtex.Component.Entities.Common.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Logistics.Warehouses.Request
{
    public class CreateUpdateWarehouseRequest : BaseLogisticsRequest
    {
        protected internal override string BaseUrl => "api/logistics/pvt/configuration/warehouses";
        public string skuId { get; set; }

        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();

            if (!string.IsNullOrEmpty(this.skuId))
            {
                parameters.Add("skuId", this.skuId);
            }
            return parameters;
        }
    }
}
