using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Catalog.SKU.Response
{
    public class GetSkuListByProductIdResponse: BaseCatalogResponse
    {
        public bool IsPersisted { get; set; }
        public bool IsRemoved { get; set; }
        public int Id { get; set; }
        public int ProductId { get; set; }
        public bool IsActive { get; set; }
        public string Name { get; set; }
        public int Height { get; set; }
        public object RealHeight { get; set; }
        public int Width { get; set; }
        public object RealWidth { get; set; }
        public int Length { get; set; }
        public object RealLength { get; set; }
        public int WeightKg { get; set; }
        public object RealWeightKg { get; set; }
        public int ModalId { get; set; }
        public string RefId { get; set; }
        public float CubicWeight { get; set; }
        public bool IsKit { get; set; }
        public object IsDynamicKit { get; set; }
        public object InternalNote { get; set; }
        public DateTime DateUpdated { get; set; }
        public float RewardValue { get; set; }
        public int CommercialConditionId { get; set; }
        public string EstimatedDateArrival { get; set; }
        public bool FlagKitItensSellApart { get; set; }
        public string ManufacturerCode { get; set; }
        public object ReferenceStockKeepingUnitId { get; set; }
        public int Position { get; set; }
        public object EditionSkuId { get; set; }
        public int ApprovedAdminId { get; set; }
        public int EditionAdminId { get; set; }
        public bool ActivateIfPossible { get; set; }
        public object SupplierCode { get; set; }
        public string MeasurementUnit { get; set; }
        public float UnitMultiplier { get; set; }
        public object IsInventoried { get; set; }
        public object IsTransported { get; set; }
        public object IsGiftCardRecharge { get; set; }
        public string ModalType { get; set; }
    }
}
