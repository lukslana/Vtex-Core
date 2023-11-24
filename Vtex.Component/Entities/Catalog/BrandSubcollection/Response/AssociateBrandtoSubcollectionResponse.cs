using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Catalog.BrandSubcollection.Response
{
    public class AssociateBrandtoSubcollectionResponse: BaseResponse
    {
        public int SubCollectionId { get; set; }
        public int BrandId { get; set; }
    }
}
