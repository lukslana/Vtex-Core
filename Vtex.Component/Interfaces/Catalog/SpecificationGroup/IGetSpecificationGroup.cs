using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Catalog.SpecificationGroup.Request;
using Vtex.Component.Entities.Catalog.SpecificationGroup.Response;

namespace Vtex.Component.Interfaces.Catalog.SpecificationGroup
{
    public interface IGetSpecificationGroup : IApi<GetSpecificationGroupRequest, GetSpecificationGroupResponse>
    {
    }
}
