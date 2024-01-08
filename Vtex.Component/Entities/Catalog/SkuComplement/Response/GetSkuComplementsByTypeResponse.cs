using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Catalog.SkuComplement.Response
{
    public class GetSkuComplementsByTypeResponse: BaseCatalogResponse
    {
        public int ParentSkuId { get; set; }
        public int[] ComplementSkuIds { get; set; }
        public string Type { get; set; }
    }
}
