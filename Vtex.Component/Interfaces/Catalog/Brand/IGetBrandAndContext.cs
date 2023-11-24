using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Catalog.Brand.Request;
using Vtex.Component.Entities.Catalog.Brand.Response;

namespace Vtex.Component.Interfaces.Catalog.Brand
{
    /// <inheritdoc />
    public interface IGetBrandAndContext : IApi<GetBrandAndContextRequest, GetBrandAndContextResponse>
    {

    }
}
