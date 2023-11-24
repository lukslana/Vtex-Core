using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Catalog.Specification.Request;
using Vtex.Component.Entities.Catalog.Specification.Response;

namespace Vtex.Component.Interfaces.Catalog.Specification
{
    public interface IUpdateSpecification : IApi<UpdateSpecificationRequest, UpdateSpecificationResponse>
    {
    }
}
