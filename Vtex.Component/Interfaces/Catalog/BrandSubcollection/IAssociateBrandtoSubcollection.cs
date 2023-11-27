using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Catalog.BrandSubcollection.Request;
using Vtex.Component.Entities.Catalog.BrandSubcollection.Response;

namespace Vtex.Component.Interfaces.Catalog.BrandSubcollection
{
    public interface IAssociateBrandtoSubcollection : IApi<AssociateBrandtoSubcollectionRequest, AssociateBrandtoSubcollectionResponse>
    {
    }
}
