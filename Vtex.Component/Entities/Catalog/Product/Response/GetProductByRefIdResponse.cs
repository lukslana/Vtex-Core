using System;

namespace Vtex.Component.Entities.Catalog.Product.Response
{
    public class GetProductByRefIdResponse: BaseResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public string LinkId { get; set; }
        public string RefId { get; set; }
        public bool IsVisible { get; set; }
        public string Description { get; set; }
        public string DescriptionShort { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string KeyWords { get; set; }
        public string Title { get; set; }
        public bool IsActive { get; set; }
        public string TaxCode { get; set; }
        public string MetaTagDescription { get; set; }
        public object SupplierId { get; set; }
        public bool ShowWithoutStock { get; set; }
        public int[] ListStoreId { get; set; }
    }
}
