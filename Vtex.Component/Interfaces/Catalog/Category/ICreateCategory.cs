using Vtex.Component.Entities.Catalog.Category.Request;
using Vtex.Component.Entities.Catalog.Category.Response;

namespace Vtex.Component.Interfaces.Catalog.Category
{
    /// <inheritdoc />
    public interface ICreateCategory : IApi<CreateCategoryRequest, CreateCategoryResponse>
    {
    }
}