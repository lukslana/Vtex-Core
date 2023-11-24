using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Catalog.SKU.Response
{
    public class UpdateSKUResponse : BaseResponse
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public bool IsActive { get; set; }
        public bool ActivateIfPossible { get; set; }
        public string Name { get; set; }
        public string RefId { get; set; }
        public float PackagedHeight { get; set; }
        public float PackagedLength { get; set; }
        public float PackagedWidth { get; set; }
        public float PackagedWeightKg { get; set; }
        public float Height { get; set; }
        public float Length { get; set; }
        public float Width { get; set; }
        public float WeightKg { get; set; }
        public float CubicWeight { get; set; }
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
        public string[] Videos { get; set; }
    }
}
