using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Catalog.SpecificationValue.Response
{
    public class GetSpecificationValueResponse : BaseCatalogResponse
    {
        public int FieldValueId { get; set; }
        public int FieldId { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public bool IsActive { get; set; }
        public int Position { get; set; }
    }
}
