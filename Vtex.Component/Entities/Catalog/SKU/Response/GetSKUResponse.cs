using System;

namespace Vtex.Component.Entities.Catalog.SKU.Response
{
    public class GetSKUResponse: BaseResponse
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public bool IsActive { get; set; }
        public bool ActivateIfPossible { get; set; }
        public string Name { get; set; }
        public string RefId { get; set; }
        public decimal PackagedHeight { get; set; }
        public decimal PackagedLength { get; set; }
        public decimal PackagedWidth { get; set; }
        public decimal PackagedWeightKg { get; set; }
        public decimal Height { get; set; }
        public decimal Length { get; set; }
        public decimal Width { get; set; }
        public decimal WeightKg { get; set; }
        public decimal CubicWeight { get; set; }
        public bool IsKit { get; set; }
        public DateTime CreationDate { get; set; }
        public float RewardValue { get; set; }
        public DateTime EstimatedDateArrival { get; set; }
        public string ManufacturerCode { get; set; }
        public float CommercialConditionId { get; set; }
        public string MeasurementUnit { get; set; }
        public float UnitMultiplier { get; set; }
        public object ModalType { get; set; }
        public bool KitItensSellApart { get; set; }
        public object[] Videos { get; set; }
    }
}
