using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Catalog.SkuEan.Response
{
    public class GetEanBySkuIDResponse: BaseResponse
    {
       public string[] Data { get; set; }
    }
}
