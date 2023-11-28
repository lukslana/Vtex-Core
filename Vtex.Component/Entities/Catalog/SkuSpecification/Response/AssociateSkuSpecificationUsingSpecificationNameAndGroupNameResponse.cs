using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Catalog.SkuSpecification.Response
{
    public class AssociateSkuSpecificationUsingSpecificationNameAndGroupNameResponse
    {
        public int Id { get; set; }
        public int SkuId { get; set; }
        public int FieldId { get; set; }
        public int FieldValueId { get; set; }
        public string Text { get; set; }
    }
}
