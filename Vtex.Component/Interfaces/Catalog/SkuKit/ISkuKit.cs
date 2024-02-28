using Vtex.Component.Entities.Catalog.SkuKit.Request;
using Vtex.Component.Entities.Catalog.SkuKit.Response;

namespace Vtex.Component.Interfaces.Catalog.SkuKit
{
    public interface ICreateSkuKit : IApi<CreateSkuKitRequest, CreateSkuKitResponse>
    {
    }

    public interface IDeleteSkuKitByKitId : IApi<DeleteSkuKitByKitIdRequest, DeleteSkuKitByKitIdResponse>
    {
    }

    public interface IDeleteSkuKitBySkuIdOrParentSkuId : IApi<DeleteSkuKitBySkuIdOrParentSkuIdRequest, DeleteSkuKitBySkuIdOrParentSkuIdResponse>
    {
    }

    public interface IGetSkuKitBySkuIdOrParentSkuId : IApi<GetSkuKitBySkuIdOrParentSkuIdRequest, GetSkuKitBySkuIdOrParentSkuIdResponse>
    {
    }

    public interface IGetSkuKit : IApi<GetSkuKitRequest, GetSkuKitResponse>
    {
    }
}
