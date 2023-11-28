using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Catalog.SKU.Request;
using Vtex.Component.Entities.Catalog.SKU.Response;

namespace Vtex.Component.Interfaces.Catalog.Sku
{
    public interface IGetSkuByRefId : IApi<GetSkuByRefIdRequest, GetSkuByRefIdResponse>
    {
    }
}
