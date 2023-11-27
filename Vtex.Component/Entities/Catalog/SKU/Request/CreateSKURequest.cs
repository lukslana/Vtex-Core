﻿using Vtex.Component.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Catalog.SKU.Request
{
    public class CreateSKURequest : BaseSKURequest
    {
        protected internal override string BaseUrl => "api/catalog/pvt/stockkeepingunit";
        public int? Id { get; set; }
        public int? ProductId { get; set; }
        public bool? IsActive { get; set; }
        public bool? ActivateIfPossible { get; set; }
        public string Name { get; set; }
        public string RefId { get; set; }
        public double PackagedHeight { get; set; }
        public double PackagedLength { get; set; }
        public double PackagedWidth { get; set; }
        public double PackagedWeightKg { get; set; }
        public double Height { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double WeightKg { get; set; }
        public double CubicWeight { get; set; }
        public bool IsKit { get; set; }
        public DateTime CreationDate { get; set; }
        public double RewardValue { get; set; }
        public DateTime EstimatedDateArrival { get; set; }
        public string ManufacturerCode { get; set; }
        public int CommercialConditionId { get; set; }
        public string MeasurementUnit { get; set; }
        public double UnitMultiplier { get; set; }
        public object ModalType { get; set; }
        public bool KitItensSellApart { get; set; }
    }
}
