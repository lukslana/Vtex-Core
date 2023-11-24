using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Catalog.ProductSpecification.Request;
using Vtex.Component.Entities.Catalog.ProductSpecification.Response;

namespace Vtex.Component.Interfaces.Catalog.ProductSpecification
{
    public interface IDeleteSpecificProductSpecification : IApi<DeleteSpecificProductSpecificationRequest, DeleteSpecificProductSpecificationResponse>
    {
    }
}
