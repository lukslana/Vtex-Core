using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Catalog.SkuEan.Response
{
    public class GetSkuByEANResponse: BaseResponse
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string NameComplete { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
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
        public Dimension Dimension { get; set; }
        public Realdimension RealDimension { get; set; }
        public string ManufacturerCode { get; set; }
        public bool IsKit { get; set; }
        public object[] KitItems { get; set; }
        public object[] Services { get; set; }
        public object[] Categories { get; set; }
        public Attachment[] Attachments { get; set; }
        public object[] Collections { get; set; }
        public Skuseller[] SkuSellers { get; set; }
        public int[] SalesChannels { get; set; }
        public Image[] Images { get; set; }
        public Skuspecification[] SkuSpecifications { get; set; }
        public Productspecification[] ProductSpecifications { get; set; }
        public string ProductClustersIds { get; set; }
        public string ProductCategoryIds { get; set; }
        public object ProductGlobalCategoryId { get; set; }
        public Productcategories ProductCategories { get; set; }
        public int CommercialConditionId { get; set; }
        public float RewardValue { get; set; }
        public Alternateids AlternateIds { get; set; }
        public string[] AlternateIdValues { get; set; }
        public string EstimatedDateArrival { get; set; }
        public string MeasurementUnit { get; set; }
        public int UnitMultiplier { get; set; }
        public object InformationSource { get; set; }
        public string ModalType { get; set; }
    }
    public class Dimension
    {
        public float cubicweight { get; set; }
        public int height { get; set; }
        public int length { get; set; }
        public int weight { get; set; }
        public int width { get; set; }
    }

    public class Realdimension
    {
        public float realCubicWeight { get; set; }
        public int realHeight { get; set; }
        public int realLength { get; set; }
        public int realWeight { get; set; }
        public int realWidth { get; set; }
    }

    public class Productcategories
    {
        public string _59 { get; set; }
    }

    public class Alternateids
    {
        public string Ean { get; set; }
        public string RefId { get; set; }
    }

    public class Attachment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string[] Keys { get; set; }
        public Field[] Fields { get; set; }
        public bool IsActive { get; set; }
        public bool IsRequired { get; set; }
    }

    public class Field
    {
        public string FieldName { get; set; }
        public string MaxCaracters { get; set; }
        public string DomainValues { get; set; }
    }

    public class Skuseller
    {
        public string SellerId { get; set; }
        public int StockKeepingUnitId { get; set; }
        public string SellerStockKeepingUnitId { get; set; }
        public bool IsActive { get; set; }
        public int FreightCommissionPercentage { get; set; }
        public int ProductCommissionPercentage { get; set; }
    }

    public class Image
    {
        public string ImageUrl { get; set; }
        public string ImageName { get; set; }
        public int FileId { get; set; }
    }

    public class Skuspecification
    {
        public int FieldId { get; set; }
        public string FieldName { get; set; }
        public int[] FieldValueIds { get; set; }
        public string[] FieldValues { get; set; }
    }

    public class Productspecification
    {
        public int FieldId { get; set; }
        public string FieldName { get; set; }
        public int?[] FieldValueIds { get; set; }
        public string[] FieldValues { get; set; }
    }
}
