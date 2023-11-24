using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Catalog.CategorySpecification.Response
{
    public class GetSpecificationsTreeByCategoryIdResponse : BaseResponse
    {
        public GetSpecificationsTreeByCategoryIdResponses[] Data { get; set; }
    }
    public class GetSpecificationsTreeByCategoryIdResponses
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int FieldId { get; set; }
        public bool IsActive { get; set; }
        public bool IsStockKeepingUnit { get; set; }
    }
}
