using Vtex.Component.Entities.Catalog.Brand.Request;
using Vtex.Component.Entities.Catalog.Brand.Response;

namespace Vtex.Component.Interfaces.Catalog.Category
{
    /// <inheritdoc />
    public interface IUpdateCategory : IApi<UpdateBrandRequest, UpdateBrandResponse>
    {
    }
}