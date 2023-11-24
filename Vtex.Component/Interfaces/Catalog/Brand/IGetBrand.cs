using Vtex.Component.Entities.Catalog.Brand.Request;
using Vtex.Component.Entities.Catalog.Brand.Response;

namespace Vtex.Component.Interfaces.Catalog.Brand
{
    /// <inheritdoc />
    public interface IGetBrand : IApi<GetBrandRequest, GetBrandResponse>
    {
    }
}