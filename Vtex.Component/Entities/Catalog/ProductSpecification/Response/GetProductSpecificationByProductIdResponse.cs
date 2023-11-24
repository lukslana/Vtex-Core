using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Catalog.ProductSpecification.Response
{
    public class GetProductSpecificationByProductIdResponse : BaseResponse
    {
        public Data[] data { get; set; }

        public class Data
        {
            public string[] Value { get; set; }
            public int Id { get; set; }
            public string Name { get; set; }
        }

    }
}
