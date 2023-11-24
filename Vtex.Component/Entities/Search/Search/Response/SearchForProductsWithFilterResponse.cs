using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Search.Search.Response
{
    public class SearchForProductsWithFilterResponse : BaseResponse
    {
        public Datum[] data { get; set; }
    }
}
