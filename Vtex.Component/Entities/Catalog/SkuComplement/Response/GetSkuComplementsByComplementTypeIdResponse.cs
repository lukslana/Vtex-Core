using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Catalog.SkuComplement.Response
{
    public class GetSkuComplementsByComplementTypeIdResponse: BaseCatalogResponse
    {
        public int Id { get; set; }
        public int SkuId { get; set; }
        public int ParentSkuId { get; set; }
        public int ComplementTypeId { get; set; }
    }
}
