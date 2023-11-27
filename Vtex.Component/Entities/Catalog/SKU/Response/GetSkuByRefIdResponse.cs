using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Catalog.SKU.Response
{
    public class GetSkuByRefIdResponse: BaseCatalogResponse
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public bool IsActive { get; set; }
        public string Name { get; set; }
        public string RefId { get; set; }
        public int PackagedHeight { get; set; }
        public int PackagedLength { get; set; }
        public int PackagedWidth { get; set; }
        public int PackagedWeightKg { get; set; }
        public int Height { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public int WeightKg { get; set; }
        public int CubicWeight { get; set; }
        public bool IsKit { get; set; }
        public DateTime CreationDate { get; set; }
        public int RewardValue { get; set; }
        public object EstimatedDateArrival { get; set; }
        public string ManufacturerCode { get; set; }
        public int CommercialConditionId { get; set; }
        public string MeasurementUnit { get; set; }
        public int UnitMultiplier { get; set; }
        public object ModalType { get; set; }
        public bool KitItensSellApart { get; set; }
        public object Videos { get; set; }
    }
}
