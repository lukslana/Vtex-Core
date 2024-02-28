using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Catalog.SkuKit.Response
{
    public class CreateSkuKitResponse : BaseResponse
    {
        public int Id { get; set; }
        public int StockKeepingUnitParent { get; set; }
        public int StockKeepingUnitId { get; set; }
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }
    }
}
