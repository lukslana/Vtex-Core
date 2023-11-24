using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Catalog.CategorySpecification.Request;
using Vtex.Component.Entities.Catalog.CategorySpecification.Response;

namespace Vtex.Component.Interfaces.Catalog.CategorySpecification
{
    public interface IGetSpecificationsTreeByCategoryId : IApi<GetSpecificationsTreeByCategoryIdRequest, GetSpecificationsTreeByCategoryIdResponse>
    {
    }
}
