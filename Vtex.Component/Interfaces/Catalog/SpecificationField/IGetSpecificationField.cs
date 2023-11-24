using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Catalog.SpecificationField.Request;
using Vtex.Component.Entities.Catalog.SpecificationField.Response;

namespace Vtex.Component.Interfaces.Catalog.SpecificationField
{
    public interface IGetSpecificationField : IApi<GetSpecificationFieldRequest, GetSpecificationFieldResponse>
    {
    }
}
