using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Catalog.SkuService.Response
{
    public class UpdateSkuServiceResponse: BaseResponse
    {
        public int Id { get; set; }
        public int SkuServiceTypeId { get; set; }
        public int SkuServiceValueId { get; set; }
        public int SkuId { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public bool IsActive { get; set; }
     

    }
}
