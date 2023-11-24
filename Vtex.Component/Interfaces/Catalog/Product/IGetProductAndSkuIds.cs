using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Catalog.Product.Request;
using Vtex.Component.Entities.Catalog.Product.Response;

namespace Vtex.Component.Interfaces.Catalog.Product
{
    public interface IGetProductAndSkuIds : IApi<GetProductAndSkuIdsRequest, GetProductAndSkuIdsResponse>
    {
    }
}
