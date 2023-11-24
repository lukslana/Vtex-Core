using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Catalog.ProductSpecification.Response
{
    public class AssociateProductSpecificationResponse: BaseCatalogResponse
    {
        public int Id { get; set; }
        public int FieldId { get; set; }
        public int FieldValueId { get; set; }
        public string Text { get; set; }
    }
}
