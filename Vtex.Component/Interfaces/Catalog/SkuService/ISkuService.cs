using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Catalog.SkuService.Request;
using Vtex.Component.Entities.Catalog.SkuService.Response;

namespace Vtex.Component.Interfaces.Catalog.SkuService
{
    public interface IGetSkuService : IApi<GetSkuServiceRequest, GetSkuServiceResponse>
    {
    }

    public interface IAssociateSkuService : IApi<AssociateSkuServiceRequest, AssociateSkuServiceResponse>
    {
    }

    public interface IDissociateSkuService : IApi<DissociateSkuServiceRequest, DissociateSkuServiceResponse>
    {
    }

    public interface IUpdateSkuService : IApi<UpdateSkuServiceRequest, UpdateSkuServiceResponse>
    {
    }
}
