using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Catalog.TradePolicy.Response
{
    public class GetTradePolicyByProductIDResponse : BaseResponse
    {
        public data[] Data { get; set; }
        public class data
        {
            public int ProductId { get; set; }
            public int StoreId { get; set; }
        }

    }
}
