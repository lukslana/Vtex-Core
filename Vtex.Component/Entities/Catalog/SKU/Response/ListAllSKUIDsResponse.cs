using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Catalog.SKU.Response
{
    public class ListAllSKUIDsResponse : BaseResponse
    {
        public long[] data { get; set; }
    }
}
