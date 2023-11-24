using Vtex.Component.Entities.Catalog.Brand.Request;
using Vtex.Component.Entities.Catalog.Brand.Response;
using Vtex.Component.Entities.Catalog.Category.Request;
using Vtex.Component.Entities.Catalog.Category.Response;

namespace Vtex.Component.Interfaces.Catalog.Category
{
    /// <inheritdoc />
    public interface IGetCategoryTree : IApi<GetCategoryTreeRequest, GetCategoryTreeResponse>
    {
    }
}