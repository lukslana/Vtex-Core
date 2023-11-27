using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Catalog.SKU.Response
{
    public class GetSKuAndContextResponse : BaseResponse
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string NameComplete { get; set; }
        public string ComplementName { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductRefId { get; set; }
        public string TaxCode { get; set; }
        public string SkuName { get; set; }
        public bool IsActive { get; set; }
        public bool IsTransported { get; set; }
        public bool IsInventoried { get; set; }
        public bool IsGiftCardRecharge { get; set; }
        public string ImageUrl { get; set; }
        public string DetailUrl { get; set; }
        public object CSCIdentification { get; set; }
        public string BrandId { get; set; }
        public string BrandName { get; set; }
        public bool IsBrandActive { get; set; }
        public Dimensions Dimension { get; set; }
        public Realdimension RealDimension { get; set; }
        public string ManufacturerCode { get; set; }
        public bool IsKit { get; set; }
        public object[] KitItems { get; set; }
        public object[] Services { get; set; }
        public object[] Categories { get; set; }
        public string[] CategoriesFullPath { get; set; }
        public object[] Attachments { get; set; }
        public object[] Collections { get; set; }
        public Skuseller[] SkuSellers { get; set; }
        public int[] SalesChannels { get; set; }
        public Image[] Images { get; set; }
        public object[] Videos { get; set; }
        public object[] SkuSpecifications { get; set; }
        public Productspecification[] ProductSpecifications { get; set; }
        public string ProductClustersIds { get; set; }
        public string ProductCategoryIds { get; set; }
        public bool IsDirectCategoryActive { get; set; }
        public object ProductGlobalCategoryId { get; set; }
        public int CommercialConditionId { get; set; }
        public float RewardValue { get; set; }
        public Alternateids AlternateIds { get; set; }
        public string[] AlternateIdValues { get; set; }
        public DateTime EstimatedDateArrival { get; set; }
        public string MeasurementUnit { get; set; }
        public float UnitMultiplier { get; set; }
        public string InformationSource { get; set; }
        public object ModalType { get; set; }
        public string KeyWords { get; set; }
        public DateTime ReleaseDate { get; set; }
        public bool ProductIsVisible { get; set; }
        public bool ShowIfNotAvailable { get; set; }
        public bool IsProductActive { get; set; }
        public int ProductFinalScore { get; set; }
 
        public class Dimensions
        {
            public float cubicweight { get; set; }
            public float height { get; set; }
            public float length { get; set; }
            public float weight { get; set; }
            public float width { get; set; }
        }

        public class Realdimension
        {
            public float realCubicWeight { get; set; }
            public float realHeight { get; set; }
            public float realLength { get; set; }
            public float realWeight { get; set; }
            public float realWidth { get; set; }
        }



        public class Alternateids
        {
            public string Ean { get; set; }
            public string RefId { get; set; }
        }

        public class Skuseller
        {
            public string SellerId { get; set; }
            public int StockKeepingUnitId { get; set; }
            public string SellerStockKeepingUnitId { get; set; }
            public bool IsActive { get; set; }
            public float FreightCommissionPercentage { get; set; }
            public float ProductCommissionPercentage { get; set; }
        }

        public class Image
        {
            public string ImageUrl { get; set; }
            public string ImageName { get; set; }
            public int FileId { get; set; }
        }

        public class Productspecification
        {
            public int FieldId { get; set; }
            public string FieldName { get; set; }
            public int[] FieldValueIds { get; set; }
            public string[] FieldValues { get; set; }
            public bool IsFilter { get; set; }
            public int FieldGroupId { get; set; }
            public string FieldGroupName { get; set; }
        }
    }
}
