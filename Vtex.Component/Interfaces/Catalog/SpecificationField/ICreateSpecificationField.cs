using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Catalog.SpecificationField.Response;
using Vtex.Component.Entities.Catalog.SpecificationField.Request;

namespace Vtex.Component.Interfaces.Catalog.SpecificationField
{
    public interface ICreateSpecificationField : IApi<CreateSpecificationFieldRequest, CreateSpecificationFieldResponse>
    {
    }
}
