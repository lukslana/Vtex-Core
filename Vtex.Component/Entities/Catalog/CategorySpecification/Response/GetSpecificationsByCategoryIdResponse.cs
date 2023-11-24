using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Catalog.CategorySpecification.Response
{
    public class GetSpecificationsByCategoryIdResponse : BaseResponse
    {
        public GetSpecificationsByCategoryIdResponses[] Data { get; set; }
    }
    public class GetSpecificationsByCategoryIdResponses
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int FieldId { get; set; }
        public bool IsActive { get; set; }
    }
}
