using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Catalog.SkuComplement.Request
{
    public class CreateSkuComplementRequest : BaseCatalogRequest
    {
        protected internal override string BaseUrl => "api/catalog/pvt/skucomplement";
        public override HttpMethod HttpMethod => HttpMethod.Post;
        public int SkuId { get; set; }
        public int ParentSkuId { get; set; }
        public int ComplementTypeId { get; set; }

    }
}
