using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Catalog.SkuSpecification.Request;
using Vtex.Component.Entities.Catalog.SkuSpecification.Response;

namespace Vtex.Component.Interfaces.Catalog.SkuSpecification
{
    public interface IDeleteAllSkuSpecifications : IApi<DeleteAllSkuSpecificationsRequest, DeleteAllSkuSpecificationsResponse>
    {
    }
}
