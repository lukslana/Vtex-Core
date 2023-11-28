using Vtex.Component.Entities.Catalog.Brand.Request;
using Vtex.Component.Entities.Catalog.Brand.Response;
using Vtex.Component.Entities.Catalog.BrandSubcollection.Request;
using Vtex.Component.Entities.Catalog.BrandSubcollection.Response;
using Vtex.Component.Entities.Catalog.Category.Request;
using Vtex.Component.Entities.Catalog.Category.Response;
using Vtex.Component.Entities.Catalog.CategorySpecification.Request;
using Vtex.Component.Entities.Catalog.CategorySpecification.Response;
using Vtex.Component.Entities.Catalog.Product.Request;
using Vtex.Component.Entities.Catalog.Product.Response;
using Vtex.Component.Entities.Catalog.ProductSpecification.Request;
using Vtex.Component.Entities.Catalog.ProductSpecification.Response;
using Vtex.Component.Entities.Catalog.SKU.Request;
using Vtex.Component.Entities.Catalog.SKU.Response;
using Vtex.Component.Entities.Catalog.SkuSpecification.Request;
using Vtex.Component.Entities.Catalog.SkuSpecification.Response;
using Vtex.Component.Entities.Catalog.Specification.Request;
using Vtex.Component.Entities.Catalog.Specification.Response;
using Vtex.Component.Entities.Catalog.SpecificationField.Request;
using Vtex.Component.Entities.Catalog.SpecificationField.Response;
using Vtex.Component.Entities.Catalog.SpecificationGroup.Request;
using Vtex.Component.Entities.Catalog.SpecificationGroup.Response;
using Vtex.Component.Interfaces.Catalog.Brand;
using Vtex.Component.Interfaces.Catalog.BrandSubcollection;
using Vtex.Component.Interfaces.Catalog.Category;
using Vtex.Component.Interfaces.Catalog.CategorySpecification;
using Vtex.Component.Interfaces.Catalog.Product;
using Vtex.Component.Interfaces.Catalog.ProductSpecification;
using Vtex.Component.Interfaces.Catalog.Sku;
using Vtex.Component.Interfaces.Catalog.SkuSpecification;
using Vtex.Component.Interfaces.Catalog.Specification;
using Vtex.Component.Interfaces.Catalog.SpecificationField;
using Vtex.Component.Interfaces.Catalog.SpecificationGroup;
using static Vtex.Component.VtexCatalog.SkuSpecification;


namespace Vtex.Component
{
    /// <summary>
    /// Product - Here you can consult, create, or update a Product. For more information, check this article.     <br></br>
    /// Get Product and SKU IDs                                                                                    <br></br>
    /// Get Product by ID                                                                                          <br></br>
    /// Update Product                                                                                             <br></br>
    /// Get Product and its general context                                                                        <br></br>
    /// Get Product by RefId                                                                                       <br></br>
    /// Get Product's SKUs by Product ID                                                                           <br></br>
    /// Get Product Review Rate by Product ID                                                                      <br></br>
    /// Create Product
    /// </summary>
    public class VtexCatalog
    {
        ///<summary>
        ///Brands work as product attributes that help end customers to identify a product and the business behind it.             <br></br>
        ///A product can only be associated with a single brand.Each product needs to be associated with a brand to exist.          <br></br>
        ///Therefore, creating a Brand is a mandatory step when configuring your Catalog.Usually, it is the second step for         <br></br>
        ///catalog integration, after creating categories.For more information on Catalog structure and integration flow at VTEX,   <br></br>
        ///check our Catalog overview.
        ///</summary>
        public static partial class Brand
        {
            /// <summary>
            /// Retrieves all Brands registered in the store's Catalog.
            /// </summary>
            public static GetBrandListApi GetBrandList => new();

            /// <summary>
            /// Retrieves all Brands registered in the store's Catalog by page number.
            /// </summary>
            public static GetBrandListPerPageApi GetBrandListPerPage   => new();

            /// <summary>
            /// Retrieves a specific Brand by its ID.
            /// </summary>
            public static GetBrandApi GetBrand => new();

            /// <summary>
            /// Creates a new Brand.
            /// </summary>
            public static CreateBrandApi CreateBrand => new();

            /// <summary>
            /// Retrieves information about a specific Brand and its context.
            /// </summary>
            public static GetBrandAndContextApi GetBrandAndContext => new();

            /// <summary>
            /// Updates a previously existing Brand.
            /// </summary>
            public static UpdateBrandApi UpdateBrand => new();

            /// <summary>
            /// Deletes an existing Brand.
            /// </summary>
            public static DeleteBrandApi DeleteBrand => new ();

            /// <summary>
            /// Retrieves all Brands registered in the store's Catalog.
            /// </summary>
            public sealed class GetBrandListApi : HttpEngine<GetBrandListRequest, GetBrandListResponse>, IGetBrandList
            {
                /// <summary>
                /// Constructor.
                /// </summary>
                public GetBrandListApi()
                {
                }

                /// <summary>
                /// Constructor.
                /// </summary>
                /// <param name="httpClient">The <see cref="HttpClient"/>.</param>
                public GetBrandListApi(HttpClient httpClient)
                    : base(httpClient)
                {

                }
            }

            /// <summary>
            /// Retrieves all Brands registered in the store's Catalog by page number.
            /// </summary>
            public sealed class GetBrandListPerPageApi : HttpEngine<GetBrandListPerPageRequest, GetBrandListPerPageResponse>, IGetBrandListPerPage
            {
                /// <summary>
                /// Constructor.
                /// </summary>
                public GetBrandListPerPageApi()
                {
                }

                /// <summary>
                /// Constructor.
                /// </summary>
                /// <param name="httpClient">The <see cref="HttpClient"/>.</param>
                public GetBrandListPerPageApi(HttpClient httpClient)
                    : base(httpClient)
                {

                }
            }


            /// <summary>
            /// Retrieves a specific Brand by its ID.
            /// </summary>
            public sealed class GetBrandApi : HttpEngine<GetBrandRequest, GetBrandResponse>, IGetBrand
            {
                /// <summary>
                /// Constructor.
                /// </summary>
                public GetBrandApi()
                {
                }

                /// <summary>
                /// Constructor.
                /// </summary>
                /// <param name="httpClient">The <see cref="HttpClient"/>.</param>
                public GetBrandApi(HttpClient httpClient)
                    : base(httpClient)
                {

                }
            }

            /// <summary>
            /// Create Brand Api
            /// </summary>
            public sealed class CreateBrandApi : HttpEngine<CreateBrandRequest, CreateBrandResponse>, ICreateBrand
            {
                /// <summary>
                /// Constructor.
                /// </summary>
                public CreateBrandApi()
                {

                }

                /// <summary>
                /// Constructor.
                /// </summary>
                /// <param name="httpClient">The <see cref="HttpClient"/>.</param>
                public CreateBrandApi(HttpClient httpClient)
                    : base(httpClient)
                {

                }
            }

            /// <summary>
            /// Get Brand and Context Api
            /// </summary>
            public sealed class GetBrandAndContextApi : HttpEngine<GetBrandAndContextRequest, GetBrandAndContextResponse>, IGetBrandAndContext
            {
                /// <summary>
                /// Constructor.
                /// </summary>
                public GetBrandAndContextApi()
                {
                }

                /// <summary>
                /// Constructor.
                /// </summary>
                /// <param name="httpClient">The <see cref="HttpClient"/>.</param>
                public GetBrandAndContextApi(HttpClient httpClient)
                    : base(httpClient)
                {

                }
            }

            /// <summary>
            /// Updates a previously existing Brand.
            /// </summary>
            public sealed class UpdateBrandApi : HttpEngine<UpdateBrandRequest, UpdateBrandResponse>, IUpdateBrand
            {
                /// <summary>
                /// Constructor.
                /// </summary>
                public UpdateBrandApi()
                {
                }

                /// <summary>
                /// Constructor.
                /// </summary>
                /// <param name="httpClient">The <see cref="HttpClient"/>.</param>
                public UpdateBrandApi(HttpClient httpClient)
                    : base(httpClient)
                {

                }
            }


            /// <summary>
            /// Deletes an existing Brand.
            /// </summary>
            public sealed class DeleteBrandApi : HttpEngine<DeleteBrandRequest, DeleteBrandResponse>, IDeleteBrand
            {
                /// <summary>
                /// Constructor.
                /// </summary>
                public DeleteBrandApi()
                {
                }

                /// <summary>
                /// Constructor.
                /// </summary>
                /// <param name="httpClient">The <see cref="HttpClient"/>.</param>
                public DeleteBrandApi(HttpClient httpClient)
                    : base(httpClient)
                {

                }
            }
        }
        /// <summary>
        /// Associates a single Brand to a Subcollection, which is a Group within a Collection.
        /// </summary>
        public static partial class BrandSubCollection
        {
            public static AssociateBrandtoSubcollectionApi AssociateBrandtoSubcollection => new();

            public sealed class AssociateBrandtoSubcollectionApi : HttpEngine<AssociateBrandtoSubcollectionRequest, AssociateBrandtoSubcollectionResponse>, IAssociateBrandtoSubcollection
            {
                /// <summary>
                /// Constructor.
                /// </summary>
                public AssociateBrandtoSubcollectionApi()
                {
                }

                /// <summary>
                /// Constructor.
                /// </summary>
                /// <param name="httpClient">The <see cref="HttpClient"/>.</param>
                public AssociateBrandtoSubcollectionApi(HttpClient httpClient)
                    : base(httpClient)
                {

                }
            }
        }
        /// <summary>
        /// Categories organize your product assortment within your ecommerce. <br></br>
        /// They work as hierarchical levels of product classification, making your client’s search for a product easier and keeping your store organized.
        /// </summary>
        public static partial class Category
        {
            /// <summary>
            /// Retrieves the Category Tree of your store.Get all the category levels registered in the Catalog or define the level up to which you want to get.
            /// </summary>
            public static GetCategoryTreeApi GetCategoryTree => new();  
            public static GetCategoryByIdApi GetCategoryById => new();
            public static UpdateCategoryApi UpdateCategory => new();
            public static CreateCategoryApi CreateCategory => new();

            /// <summary>
            /// Retrieves the Category Tree of your store. Get all the category levels registered in the Catalog or define the level up to which you want to get.
            /// </summary>
            public sealed class GetCategoryTreeApi : HttpEngine<GetCategoryTreeRequest, GetCategoryTreeResponse>, IGetCategoryTree
            {
                /// <summary>
                /// Constructor.
                /// </summary>
                public GetCategoryTreeApi()
                {
                }

                /// <summary>
                /// Constructor.
                /// </summary>
                /// <param name="httpClient">The <see cref="HttpClient"/>.</param>
                public GetCategoryTreeApi(HttpClient httpClient)
                    : base(httpClient)
                {

                }
            }

            /// <summary>
            /// Retrieves general information about a Category.
            /// </summary>
            public sealed class GetCategoryByIdApi : HttpEngine<GetCategoryByIdRequest, GetCategoryByIdResponse>, IGetCategoryById
            {
                /// <summary>
                /// Constructor.
                /// </summary>
                public GetCategoryByIdApi()
                {
                }

                /// <summary>
                /// Constructor.
                /// </summary>
                /// <param name="httpClient">The <see cref="HttpClient"/>.</param>
                public GetCategoryByIdApi(HttpClient httpClient)
                    : base(httpClient)
                {

                }
            }

            /// <summary>
            /// Updates a previously existing Category.
            /// </summary>
            public sealed class UpdateCategoryApi : HttpEngine<UpdateBrandRequest, UpdateBrandResponse>, IUpdateCategory
            {
                /// <summary>
                /// Constructor.
                /// </summary>
                public UpdateCategoryApi()
                {
                }

                /// <summary>
                /// Constructor.
                /// </summary>
                /// <param name="httpClient">The <see cref="HttpClient"/>.</param>
                public UpdateCategoryApi(HttpClient httpClient)
                    : base(httpClient)
                {

                }
            }

            /// <summary>
            /// Creates a new Category. <br></br>
            /// If there is a need to create a new category with a specific custom ID, specify the Id(integer) in the request.Otherwise, VTEX will generate the ID automatically.
            /// </summary>
            public sealed class CreateCategoryApi : HttpEngine<CreateCategoryRequest, CreateCategoryResponse>, ICreateCategory
            {
                /// <summary>
                /// Constructor.
                /// </summary>
                public CreateCategoryApi()
                {
                }

                /// <summary>
                /// Constructor.
                /// </summary>
                /// <param name="httpClient">The <see cref="HttpClient"/>.</param>
                public CreateCategoryApi(HttpClient httpClient)
                    : base(httpClient)
                {
                }
            }
        }
        /// <summary>
        /// Categories organize your product assortment within your ecommerce. They work as hierarchical levels of product classification, making your client’s search for a product easier and keeping your store organized.
        /// </summary>
        public static partial class CategorySpecification
        {
            /// <summary>
            /// Retrieves all specifications from a category by its ID. 
            /// </summary>
            public static GetSpecificationsByCategoryIdApi GetSpecificationsByCategoryId => new();

            /// <summary>
            /// Lists all specifications including the current category and the level zero specifications from a category by its ID.
            /// </summary>
            public static GetSpecificationsTreeByCategoryIdApi GetSpecificationsTreeByCategoryId => new();
            public sealed class GetSpecificationsByCategoryIdApi : HttpEngine<GetSpecificationsByCategoryIdRequest, GetSpecificationsByCategoryIdResponse>, IGetSpecificationsByCategoryId
            {
                /// <summary>
                /// Constructor.
                /// </summary>
                public GetSpecificationsByCategoryIdApi()
                {
                }

                /// <summary>
                /// Constructor.
                /// </summary>
                /// <param name="httpClient">The <see cref="HttpClient"/>.</param>
                public GetSpecificationsByCategoryIdApi(HttpClient httpClient)
                    : base(httpClient)
                {

                }
            }
            public sealed class GetSpecificationsTreeByCategoryIdApi : HttpEngine<GetSpecificationsTreeByCategoryIdRequest, GetSpecificationsTreeByCategoryIdResponse>, IGetSpecificationsTreeByCategoryId
            {
                /// <summary>
                /// Constructor.
                /// </summary>
                public GetSpecificationsTreeByCategoryIdApi()
                {
                }

                /// <summary>
                /// Constructor.
                /// </summary>
                /// <param name="httpClient">The <see cref="HttpClient"/>.</param>
                public GetSpecificationsTreeByCategoryIdApi(HttpClient httpClient)
                    : base(httpClient)
                {

                }
            }
        }
        /// <summary>
        ///A product is a generic definition of an item that is part of your store’s <b>Catalog</b>, for instance, a shirt.<br></br>
        ///Products may vary by model, color, size, among other characteristics.Therefore, it would be possible to have the same product(shirt) in different models, like short or long sleeves, gray or pink color, sizes S, M or L.<br></br>
        ///Each variation, such as a long sleeve gray size S shirt, will correspond to a Stock Keeping Unit (SKU), which is the actual item in the inventory that customers can purchase. Before creating SKUs, you must create a product.<br></br>
        /// </summary>
        public static partial class Product
        {
            /// <summary>
            /// Retrieves the IDs of products and SKUs.
            /// </summary>
            public static GetProductAndSkuIdsApi GetProductAndSkuIds => new ();

            /// <summary>
            /// Retrieves a specific Product by its ID. This information is exactly what is needed to create a new Product.
            /// </summary>
            public static GetProductByIdApi GetProductById => new ();

            /// <summary>
            ///Updates an existing Product.
            /// </summary>
            public static UpdateProductApi UpdateProduct => new ();

            /// <summary>
            /// Retrieves a specific product's general information as name, description and the trade policies that it is included.
            /// </summary>
            public static GetProductAndItsGeneralContextApi GetProductAndItsGeneralContext => new ();

            /// <summary>
            /// Retrieves a specific product by its Reference ID.
            /// </summary>
            public static GetProductByRefIdApi GetProductByRefId => new ();

            /// <summary>
            /// Retrieves data about the product and all SKUs related to it by the product's ID.
            /// </summary>
            public static GetProductSkusByProductIdApi GetProductSkusByProductId => new ();

            /// <summary>
            /// Retrieves the review rate of a product by this product's ID.
            /// </summary>
            public static GetProductReviewRateByProductIdApi GetProductReviewRateByProductId => new ();

            /// <summary>
            /// This endpoint allows two types of request: <br></br>
            /// Type 1: Creating a new Product as well as a new Category path(including subcategories) and a new Brand by using CategoryPath and BrandName parameters. <br></br>
            /// Type 2: Creating a new Product given an existing BrandId and an existing CategoryId. <br></br>
            /// When creating a product, regardless of the type of request, if there is a need to create a new product with a specific custom product ID, specify the Id(integer) in the request body.Otherwise, VTEX will generate the ID automatically.
            /// </summary>
            public static CreateProductWithCategoryAndBrandApi CreateProductWithCategoryAndBrand => new ();

            public sealed class GetProductAndSkuIdsApi : HttpEngine<GetProductAndSkuIdsRequest, GetProductAndSkuIdsResponse>, IGetProductAndSkuIds
            {
                /// <summary>
                /// Constructor.
                /// </summary>
                public GetProductAndSkuIdsApi()
                {
                }

                /// <summary>
                /// Constructor.
                /// </summary>
                /// <param name="httpClient">The <see cref="HttpClient"/>.</param>
                public GetProductAndSkuIdsApi(HttpClient httpClient)
                    : base(httpClient)
                {

                }
            }
            public sealed class GetProductByIdApi : HttpEngine<GetProductbyIDRequest, GetProductbyIDResponse>, IGetProductById
            {
                /// <summary>
                /// Constructor.
                /// </summary>
                public GetProductByIdApi()
                {
                }

                /// <summary>
                /// Constructor.
                /// </summary>
                /// <param name="httpClient">The <see cref="HttpClient"/>.</param>
                public GetProductByIdApi(HttpClient httpClient)
                    : base(httpClient)
                {
                }
            }
            public sealed class UpdateProductApi : HttpEngine<UpdateProductRequest, UpdateProductResponse>, IUpdateProduct
            {
                /// <summary>
                /// Constructor.
                /// </summary>
                public UpdateProductApi()
                {
                }

                /// <summary>
                /// Constructor.
                /// </summary>
                /// <param name="httpClient">The <see cref="HttpClient"/>.</param>
                public UpdateProductApi(HttpClient httpClient)
                    : base(httpClient)
                {

                }
            }
            public sealed class GetProductAndItsGeneralContextApi : HttpEngine<GetProductAndItsGeneralContextRequest, GetProductAndItsGeneralContextResponse>, IGetProductAndItsGeneralContext
            {
                /// <summary>
                /// Constructor.
                /// </summary>
                public GetProductAndItsGeneralContextApi()
                {
                }

                /// <summary>
                /// Constructor.
                /// </summary>
                /// <param name="httpClient">The <see cref="HttpClient"/>.</param>
                public GetProductAndItsGeneralContextApi(HttpClient httpClient)
                    : base(httpClient)
                {

                }
            }
            public sealed class GetProductByRefIdApi : HttpEngine<GetProductByRefIdRequest, GetProductByRefIdResponse>, IGetProductByRefId
            {
                /// <summary>
                /// Constructor.
                /// </summary>
                public GetProductByRefIdApi()
                {
                }

                /// <summary>
                /// Constructor.
                /// </summary>
                /// <param name="httpClient">The <see cref="HttpClient"/>.</param>
                public GetProductByRefIdApi(HttpClient httpClient)
                    : base(httpClient)
                {

                }
            }
            public sealed class GetProductSkusByProductIdApi : HttpEngine<GetProductSkusByProductIdRequest, GetProductSkusByProductIdResponse>, IGetProductSkusByProductId
            {
                /// <summary>
                /// Constructor.
                /// </summary>
                public GetProductSkusByProductIdApi()
                {
                }

                /// <summary>
                /// Constructor.
                /// </summary>
                /// <param name="httpClient">The <see cref="HttpClient"/>.</param>
                public GetProductSkusByProductIdApi(HttpClient httpClient)
                    : base(httpClient)
                {

                }
            }
            public sealed class GetProductReviewRateByProductIdApi : HttpEngine<GetProductReviewRateByProductIdRequest, GetProductReviewRateByProductIdResponse>, IGetProductReviewRateByProductId
            {
                /// <summary>
                /// Constructor.
                /// </summary>
                public GetProductReviewRateByProductIdApi()
                {
                }

                /// <summary>
                /// Constructor.
                /// </summary>
                /// <param name="httpClient">The <see cref="HttpClient"/>.</param>
                public GetProductReviewRateByProductIdApi(HttpClient httpClient)
                    : base(httpClient)
                {

                }
            }
            public sealed class CreateProductWithCategoryAndBrandApi : HttpEngine<CreateProductWithCategoryAndBrandRequest, CreateProductWithCategoryAndBrandResponse>, ICreateProductWithCategoryAndBrand
            {
                /// <summary>
                /// Constructor.
                /// </summary>
                public CreateProductWithCategoryAndBrandApi()
                {
                }

                /// <summary>
                /// Constructor.
                /// </summary>
                /// <param name="httpClient">The <see cref="HttpClient"/>.</param>
                public CreateProductWithCategoryAndBrandApi(HttpClient httpClient)
                    : base(httpClient)
                {

                }
            }
        }
        /// <summary>
        /// To create a product specification, use the API below. Remembering that you must have saved the ID of the field for which you want to create a specification.
        /// </summary>
        public static partial class ProductSpecification
        {
            /// <summary>
            /// Retrieves all specifications of a product by the product's ID.
            /// </summary>
            public static GetProductSpecificationByProductIdApi GetProductSpecificationByProductId => new();

            /// <summary>
            /// Updates the value of a product specification by the product's ID. The ID or name can be used to identify what product specification will be updated. Specification fields must be previously created in your Catalog.
            /// </summary>
            public static UpdateProductSpecificationByProductIdApi UpdateProductSpecificationByProductId => new();

            /// <summary>
            /// Retrieves information of all specifications of a product by the product's ID.
            /// </summary>
            public static GetProductSpecificationAndItsInformationByProductIdApi GetProductSpecificationAndItsInformationByProductId => new();

            /// <summary>
            /// Associates a previously defined Specification to a Product.
            /// </summary>
            public static AssociateProductSpecificationApi AssociateProductSpecification => new();

            /// <summary>
            /// Delete all Product Specifications by Product ID
            /// </summary>
            public static DeleteAllProductSpecificationsByProductIdApi DeleteAllProductSpecificationsByProductId => new();

            /// <summary>
            /// Deletes a specific Product Specification given a Product ID and a Specification ID.
            /// </summary>
            public static DeleteSpecificProductSpecificationApi DeleteSpecificProductSpecification => new();

            /// <summary>
            /// Associate product specification using specification name and group name
            /// Associates a specification to a product using specification name and group name. Automatically creates the informed group, specification and values if they had not been created before.
            /// </summary>
            public static AssociateProductSpecificationUsingSpecificationNameAndGroupNameApi AssociateProductSpecificationUsingSpecificationNameAndGroupName => new();

            public sealed class GetProductSpecificationByProductIdApi : HttpEngine<GetProductSpecificationByProductIdRequest, GetProductSpecificationByProductIdResponse>, IGetProductSpecificationByProductId
            {
                /// <summary>
                /// Constructor.
                /// </summary>
                public GetProductSpecificationByProductIdApi()
                {
                }

                /// <summary>
                /// Constructor.
                /// </summary>
                /// <param name=""httpClient"">The <see cref=""HttpClient""/>.</param>
                public GetProductSpecificationByProductIdApi(HttpClient httpClient)
                    : base(httpClient)
                {
                }
            }
            public sealed class UpdateProductSpecificationByProductIdApi : HttpEngine<UpdateProductSpecificationByProductIdRequest, UpdateProductSpecificationByProductIdResponse>, IUpdateProductSpecificationByProductId
            {
                /// <summary>
                /// Constructor.
                /// </summary>
                public UpdateProductSpecificationByProductIdApi()
                {
                }
                /// <summary>
                /// Constructor.
                /// </summary>
                /// <param name=""httpClient"">The <see cref=""HttpClient""/>.</param>
                public UpdateProductSpecificationByProductIdApi(HttpClient httpClient)
                    : base(httpClient)
                {

                }
            }
            public sealed class GetProductSpecificationAndItsInformationByProductIdApi : HttpEngine<GetProductSpecificationAndItsInformationByProductIdRequest, GetProductSpecificationAndItsInformationByProductIdResponse>, IGetProductSpecificationAndItsInformationByProductId
            {
                /// <summary>
                /// Constructor.
                /// </summary>
                public GetProductSpecificationAndItsInformationByProductIdApi()
                {
                }
                /// <summary>
                /// Constructor.
                /// </summary>
                /// <param name=""httpClient"">The <see cref=""HttpClient""/>.</param>
                public GetProductSpecificationAndItsInformationByProductIdApi(HttpClient httpClient)
                    : base(httpClient)
                {
                }
            }
            public sealed class AssociateProductSpecificationApi : HttpEngine<AssociateProductSpecificationRequest, AssociateProductSpecificationResponse>, IAssociateProductSpecification
            {
                /// <summary>
                /// Constructor.
                /// </summary>
                public AssociateProductSpecificationApi()
                {
                }
                /// <summary>
                /// Constructor.
                /// </summary>
                /// <param name=""httpClient"">The <see cref=""HttpClient""/>.</param>
                public AssociateProductSpecificationApi(HttpClient httpClient)
                    : base(httpClient)
                {
                }
            }
            public sealed class DeleteAllProductSpecificationsByProductIdApi : HttpEngine<DeleteAllProductSpecificationsByProductIdRequest, DeleteAllProductSpecificationsByProductIdResponse>, IDeleteAllProductSpecificationsByProductId
            {
                /// <summary>
                /// Constructor.
                /// </summary>
                public DeleteAllProductSpecificationsByProductIdApi()
                {
                }
                /// <summary>
                /// Constructor.
                /// </summary>
                /// <param name=""httpClient"">The <see cref=""HttpClient""/>.</param>
                public DeleteAllProductSpecificationsByProductIdApi(HttpClient httpClient)
                    : base(httpClient)
                {
                }
            }
            public sealed class DeleteSpecificProductSpecificationApi : HttpEngine<DeleteSpecificProductSpecificationRequest, DeleteSpecificProductSpecificationResponse>, IDeleteSpecificProductSpecification
            {
                /// <summary>
                /// Constructor.
                /// </summary>
                public DeleteSpecificProductSpecificationApi()
                {
                }
                /// <summary>
                /// Constructor.
                /// </summary>
                /// <param name=""httpClient"">The <see cref=""HttpClient""/>.</param>
                public DeleteSpecificProductSpecificationApi(HttpClient httpClient)
                    : base(httpClient)
                {
                }
            }
            public sealed class AssociateProductSpecificationUsingSpecificationNameAndGroupNameApi: HttpEngine<AssociateProductSpecificationUsingSpecificationNameAndGroupNameRequest, AssociateProductSpecificationUsingSpecificationNameAndGroupNameResponse>, IAssociateProductSpecificationUsingSpecificationNameAndGroupName
            {
                /// <summary>
                /// Constructor.
                /// </summary>
                public AssociateProductSpecificationUsingSpecificationNameAndGroupNameApi()
                {
                }
                /// <summary>
                /// Constructor.
                /// </summary>
                /// <param name=""httpClient"">The <see cref=""HttpClient""/>.</param>
                public AssociateProductSpecificationUsingSpecificationNameAndGroupNameApi(HttpClient httpClient)
                    : base(httpClient)
                {
                }
            }
        }
        /// <summary>
        /// Specifications are additional properties that can be added to your store's products or SKUs. A specification is used to create site browsing filters and to differentiate SKUs and products within the product page.
        /// </summary>
        public static partial class Specification
        {
            public static GetSpecificationApi GetSpecification => new();
            public static UpdateSpecificationApi UpdateSpecification => new();
            public static CreateSpecificationApi CreateSpecification => new();

            public sealed class GetSpecificationApi : HttpEngine<GetSpecificationRequest, GetSpecificationResponse>, IGetSpecification
            {
                /// <summary>
                /// Constructor.
                /// </summary>
                public GetSpecificationApi()
                {
                }

                /// <summary>
                /// Constructor.
                /// </summary>
                /// <param name=""httpClient"">The <see cref=""HttpClient""/>.</param>
                public GetSpecificationApi(HttpClient httpClient)
                    : base(httpClient)
                {
                }
            }
            public sealed class UpdateSpecificationApi : HttpEngine<UpdateSpecificationRequest, UpdateSpecificationResponse>, IUpdateSpecification
            {
                /// <summary>
                /// Constructor.
                /// </summary>
                public UpdateSpecificationApi()
                {
                }

                /// <summary>
                /// Constructor.
                /// </summary>
                /// <param name=""httpClient"">The <see cref=""HttpClient""/>.</param>
                public UpdateSpecificationApi(HttpClient httpClient)
                    : base(httpClient)
                {
                }
            }
            public sealed class CreateSpecificationApi : HttpEngine<CreateSpecificationRequest, CreateSpecificationResponse>, ICreateSpecification
            {
                /// <summary>
                /// Constructor.
                /// </summary>
                public CreateSpecificationApi()
                {
                }

                /// <summary>
                /// Constructor.
                /// </summary>
                /// <param name=""httpClient"">The <see cref=""HttpClient""/>.</param>
                public CreateSpecificationApi(HttpClient httpClient)
                    : base(httpClient)
                {
                }
            }
        }
        /// <summary>
        /// The groups and fields created will be valid for its registration category and for all child categories. For example, if a field is created in the root category, it will be available in all store categories.
        /// </summary>
        public static partial class SpecificationField
        {
            public static GetSpecificationFieldApi GetSpecificationField => new();
            public static CreateSpecificationFieldApi CreateSpecificationField => new();
            public static UpdateSpecificationFieldApi UpdateSpecificationField => new();
            public sealed class GetSpecificationFieldApi : HttpEngine<GetSpecificationFieldRequest, GetSpecificationFieldResponse>, IGetSpecificationField
            {
                /// <summary>
                /// Constructor.
                /// </summary>
                public GetSpecificationFieldApi()
                {
                }

                /// <summary>
                /// Constructor.
                /// </summary>
                /// <param name=""httpClient"">The <see cref=""HttpClient""/>.</param>
                public GetSpecificationFieldApi(HttpClient httpClient)
                    : base(httpClient)
                {
                }
            }
            public sealed class CreateSpecificationFieldApi : HttpEngine<CreateSpecificationFieldRequest, CreateSpecificationFieldResponse>, ICreateSpecificationField
            {
                /// <summary>
                /// Constructor.
                /// </summary>
                public CreateSpecificationFieldApi()
                {
                }

                /// <summary>
                /// Constructor.
                /// </summary>
                /// <param name=""httpClient"">The <see cref=""HttpClient""/>.</param>
                public CreateSpecificationFieldApi(HttpClient httpClient)
                    : base(httpClient)
                {
                }
            }
            public sealed class UpdateSpecificationFieldApi : HttpEngine<UpdateSpecificationFieldRequest, UpdateSpecificationFieldResponse>, IUpdateSpecificationField
            {
                /// <summary>
                /// Constructor.
                /// </summary>
                public UpdateSpecificationFieldApi()
                {
                }

                /// <summary>
                /// Constructor.
                /// </summary>
                /// <param name=""httpClient"">The <see cref=""HttpClient""/>.</param>
                public UpdateSpecificationFieldApi(HttpClient httpClient)
                    : base(httpClient)
                {
                }
            }
        }
        /// <summary>
        /// To create specifications, the first step is to create specification groups. They are specification aggregators, for example, we can create a group named Technical Specifications, and in it we can insert specifications referring to the product's technical data, such as material, voltage, dimensions, etc.
        /// </summary>
        public static partial class SpecificationGroup
        {

            public static ListSpecificationGroupByCategoryApi ListSpecificationGroupByCategory => new();
            public static GetSpecificationGroupApi GetSpecificationGroup => new();
            public static CreateSpecificationGroupApi CreateSpecificationGroup => new();
            public static UpdateSpecificationGroupApi UpdateSpecificationGroup => new();

            public sealed class ListSpecificationGroupByCategoryApi : HttpEngine<ListSpecificationGroupByCategoryRequest, ListSpecificationGroupByCategoryResponse>, IListSpecificationGroupByCategory
            {
                /// <summary>
                /// Constructor.
                /// </summary>
                public ListSpecificationGroupByCategoryApi()
                {
                }

                /// <summary>
                /// Constructor.
                /// </summary>
                /// <param name=""httpClient"">The <see cref=""HttpClient""/>.</param>
                public ListSpecificationGroupByCategoryApi(HttpClient httpClient)
                    : base(httpClient)
                {
                }
            }
            public sealed class GetSpecificationGroupApi : HttpEngine<GetSpecificationGroupRequest, GetSpecificationGroupResponse>, IGetSpecificationGroup
            {
                /// <summary>
                /// Constructor.
                /// </summary>
                public GetSpecificationGroupApi()
                {
                }

                /// <summary>
                /// Constructor.
                /// </summary>
                /// <param name=""httpClient"">The <see cref=""HttpClient""/>.</param>
                public GetSpecificationGroupApi(HttpClient httpClient)
                    : base(httpClient)
                {
                }
            }
            public sealed class CreateSpecificationGroupApi : HttpEngine<CreateSpecificationGroupRequest, CreateSpecificationGroupResponse>, ICreateSpecificationGroup
            {
                /// <summary>
                /// Constructor.
                /// </summary>
                public CreateSpecificationGroupApi()
                {
                }

                /// <summary>
                /// Constructor.
                /// </summary>
                /// <param name=""httpClient"">The <see cref=""HttpClient""/>.</param>
                public CreateSpecificationGroupApi(HttpClient httpClient)
                    : base(httpClient)
                {
                }
            }
            public sealed class UpdateSpecificationGroupApi : HttpEngine<UpdateSpecificationGroupRequest, UpdateSpecificationGroupResponse>, IUpdateSpecificationGroup
            {
                /// <summary>
                /// Constructor.
                /// </summary>
                public UpdateSpecificationGroupApi()
                {
                }

                /// <summary>
                /// Constructor.
                /// </summary>
                /// <param name=""httpClient"">The <see cref=""HttpClient""/>.</param>
                public UpdateSpecificationGroupApi(HttpClient httpClient)
                    : base(httpClient)
                {
                }
            }

        }
        /// <summary>
        /// A Stock Keeping Unit (SKU) corresponds to the actual item in the inventory that customers can purchase, which means it is equivalent to a product variation at VTEX, such as a long sleeve gray size S shirt. <br></br>
        ///Once you have created a product, it is time to submit its respective SKUs. <br></br>
        /// </summary>
        public static partial class Sku
        {
            /// <summary>
            /// Creates a new SKU.
            ///If there is a need to create a new SKU with a specific custom ID, specify the Id(integer) in the request.Otherwise, VTEX will generate the ID automatically.
            /// </summary>
            public static CreateSkuApi CreateSku => new ();

            /// <summary>
            /// Retrieves context of an SKU.
            /// </summary>
            public static GetSkuAndContextApi GetSkuAndContext => new ();

            /// <summary>
            /// Retrieves an SKU by its Alternate ID.
            /// </summary>
            public static GetSkuByAlternateIdApi GetSkuByAlternateId => new ();

            /// <summary>
            /// Retrieves an SKU ID by the SKU's Reference ID.
            /// </summary>
            public static GetSkuByRefIdApi GetSkuByRefId => new ();
            /// <summary>
            /// Retrieves a list with the SKUs related to a product by the product's ID.
            /// </summary>
            public static GetSkuListByProductIdApi GetSkuListByProductId => new ();

            /// <summary>
            /// Retrieves a specific SKU by its ID.
            /// </summary>
            public static GetSkuApi GetSku => new ();

            /// <summary>
            /// Retrieves the IDs of all SKUs in your store. Presents the results with page size and pagination.
            /// </summary>
            public static ListAllSkuIdsApi ListAllSkuIds => new ();

            /// <summary>
            /// Receives a list of Reference IDs and returns a list with the corresponding SKU IDs.
            /// </summary>
            public static RetrieveSkuIdListByReferenceIdListApi RetrieveSkuIdListByReferenceIdList => new ();

            /// <summary>
            /// Updates an existing SKU.    
            /// </summary>
            public static UpdateSkuApi UpdateSku  => new ();

            public sealed class CreateSkuApi : HttpEngine<CreateSkuRequest, CreateSkuResponse>, ICreateSku
            {
                /// <summary>
                /// Constructor.
                /// </summary>
                public CreateSkuApi()
                {
                }

                /// <summary>
                /// Constructor.
                /// </summary>
                /// <param name=""httpClient"">The <see cref=""HttpClient""/>.</param>
                public CreateSkuApi(HttpClient httpClient)
                    : base(httpClient)
                {
                }
            }

            public sealed class GetSkuAndContextApi : HttpEngine<GetSkuAndContextRequest, GetSkuAndContextResponse>, IGetSkuAndContext
            {
                /// <summary>
                /// Constructor.
                /// </summary>
                public GetSkuAndContextApi()
                {
                }

                /// <summary>
                /// Constructor.
                /// </summary>
                /// <param name=""httpClient"">The <see cref=""HttpClient""/>.</param>
                public GetSkuAndContextApi(HttpClient httpClient)
                    : base(httpClient)
                {
                }
            }

            public sealed class GetSkuByAlternateIdApi : HttpEngine<GetSkuByAlternateIdRequest, GetSkuByAlternateIdResponse>, IGetSkuByAlternateId
            {
                /// <summary>
                /// Constructor.
                /// </summary>
                public GetSkuByAlternateIdApi()
                {
                }

                /// <summary>
                /// Constructor.
                /// </summary>
                /// <param name=""httpClient"">The <see cref=""HttpClient""/>.</param>
                public GetSkuByAlternateIdApi(HttpClient httpClient)
                    : base(httpClient)
                {
                }
            }

            public sealed class GetSkuByRefIdApi : HttpEngine<GetSkuByRefIdRequest, GetSkuByRefIdResponse>, IGetSkuByRefId
            {
                /// <summary>
                /// Constructor.
                /// </summary>
                public GetSkuByRefIdApi()
                {
                }

                /// <summary>
                /// Constructor.
                /// </summary>
                /// <param name=""httpClient"">The <see cref=""HttpClient""/>.</param>
                public GetSkuByRefIdApi(HttpClient httpClient)
                    : base(httpClient)
                {
                }
            }

            public sealed class GetSkuListByProductIdApi : HttpEngine<GetSkuListByProductIdRequest, GetSkuListByProductIdResponse>, IGetSkuListByProductId
            {
                /// <summary>
                /// Constructor.
                /// </summary>
                public GetSkuListByProductIdApi()
                {
                }

                /// <summary>
                /// Constructor.
                /// </summary>
                /// <param name=""httpClient"">The <see cref=""HttpClient""/>.</param>
                public GetSkuListByProductIdApi(HttpClient httpClient)
                    : base(httpClient)
                {
                }
            }

            public sealed class GetSkuApi : HttpEngine<GetSkuRequest, GetSkuResponse>, IGetSku
            {
                /// <summary>
                /// Constructor.
                /// </summary>
                public GetSkuApi()
                {
                }

                /// <summary>
                /// Constructor.
                /// </summary>
                /// <param name=""httpClient"">The <see cref=""HttpClient""/>.</param>
                public GetSkuApi(HttpClient httpClient)
                    : base(httpClient)
                {
                }
            }

            public sealed class ListAllSkuIdsApi : HttpEngine<ListAllSkuIdsRequest, ListAllSkuIdsResponse>, IListAllSkuIds
            {
                /// <summary>
                /// Constructor.
                /// </summary>
                public ListAllSkuIdsApi()
                {
                }

                /// <summary>
                /// Constructor.
                /// </summary>
                /// <param name=""httpClient"">The <see cref=""HttpClient""/>.</param>
                public ListAllSkuIdsApi(HttpClient httpClient)
                    : base(httpClient)
                {
                }
            }

            public sealed class RetrieveSkuIdListByReferenceIdListApi : HttpEngine<RetrieveSkuIdListByReferenceIdListRequest, RetrieveSkuIdListByReferenceIdListResponse>, IRetrieveSkuIdListByReferenceIdList
            {
                /// <summary>
                /// Constructor.
                /// </summary>
                public RetrieveSkuIdListByReferenceIdListApi()
                {
                }

                /// <summary>
                /// Constructor.
                /// </summary>
                /// <param name=""httpClient"">The <see cref=""HttpClient""/>.</param>
                public RetrieveSkuIdListByReferenceIdListApi(HttpClient httpClient)
                    : base(httpClient)
                {
                }
            }

            public sealed class UpdateSkuApi : HttpEngine<UpdateSkuRequest, UpdateSkuResponse>, IUpdateSku
            {
                /// <summary>
                /// Constructor.
                /// </summary>
                public UpdateSkuApi()
                {
                }

                /// <summary>
                /// Constructor.
                /// </summary>
                /// <param name=""httpClient"">The <see cref=""HttpClient""/>.</param>
                public UpdateSkuApi(HttpClient httpClient)
                    : base(httpClient)
                {
                }
            }

        }
        public static partial class SkuSpecification
        {
            public static AssociateSkuSpecificationApi AssociateSkuSpecification => new();
            public static AssociateSkuSpecificationUsingSpecificationNameAndGroupNameApi AssociateSkuSpecificationUsingSpecificationNameAndGroupName => new();
            public static DeleteAllSkuSpecificationsApi DeleteAllSkuSpecifications => new();
            public static DeleteSkuSpecificationApi DeleteSkuSpecification => new();
            public static GetSkuSpecificationsApi GetSkuSpecifications => new();
            public static UpdateSkuSpecificationApi UpdateSkuSpecification => new();
            public sealed class AssociateSkuSpecificationApi : HttpEngine<AssociateSkuSpecificationRequest, AssociateSkuSpecificationResponse>, IAssociateSkuSpecification
            {
                /// <summary>
                /// Constructor.
                /// </summary>
                public AssociateSkuSpecificationApi()
                {
                }

                /// <summary>
                /// Constructor.
                /// </summary>
                /// <param name=""httpClient"">The <see cref=""HttpClient""/>.</param>
                public AssociateSkuSpecificationApi(HttpClient httpClient)
                    : base(httpClient)
                {
                }
            }
            public sealed class AssociateSkuSpecificationUsingSpecificationNameAndGroupNameApi : HttpEngine<AssociateSkuSpecificationUsingSpecificationNameAndGroupNameRequest, AssociateSkuSpecificationUsingSpecificationNameAndGroupNameResponse>, IAssociateSkuSpecificationUsingSpecificationNameAndGroupName
            {
                /// <summary>
                /// Constructor.
                /// </summary>
                public AssociateSkuSpecificationUsingSpecificationNameAndGroupNameApi()
                {
                }

                /// <summary>
                /// Constructor.
                /// </summary>
                /// <param name=""httpClient"">The <see cref=""HttpClient""/>.</param>
                public AssociateSkuSpecificationUsingSpecificationNameAndGroupNameApi(HttpClient httpClient)
                    : base(httpClient)
                {
                }
            }
            public sealed class DeleteAllSkuSpecificationsApi : HttpEngine<DeleteAllSkuSpecificationsRequest, DeleteAllSkuSpecificationsResponse>, IDeleteAllSkuSpecifications
            {
                /// <summary>
                /// Constructor.
                /// </summary>
                public DeleteAllSkuSpecificationsApi()
                {
                }

                /// <summary>
                /// Constructor.
                /// </summary>
                /// <param name=""httpClient"">The <see cref=""HttpClient""/>.</param>
                public DeleteAllSkuSpecificationsApi(HttpClient httpClient)
                    : base(httpClient)
                {
                }
            }
            public sealed class DeleteSkuSpecificationApi : HttpEngine<DeleteSkuSpecificationRequest, DeleteSkuSpecificationResponse>, IDeleteSkuSpecification
            {
                /// <summary>
                /// Constructor.
                /// </summary>
                public DeleteSkuSpecificationApi()
                {
                }

                /// <summary>
                /// Constructor.
                /// </summary>
                /// <param name=""httpClient"">The <see cref=""HttpClient""/>.</param>
                public DeleteSkuSpecificationApi(HttpClient httpClient)
                    : base(httpClient)
                {
                }
            }
            public sealed class GetSkuSpecificationsApi : HttpEngine<GetSkuSpecificationsRequest, GetSkuSpecificationsResponse>, IGetSkuSpecifications
            {
                /// <summary>
                /// Constructor.
                /// </summary>
                public GetSkuSpecificationsApi()
                {
                }

                /// <summary>
                /// Constructor.
                /// </summary>
                /// <param name=""httpClient"">The <see cref=""HttpClient""/>.</param>
                public GetSkuSpecificationsApi(HttpClient httpClient)
                    : base(httpClient)
                {
                }
            }
            public sealed class UpdateSkuSpecificationApi : HttpEngine<UpdateSkuSpecificationRequest, UpdateSkuSpecificationResponse>, IUpdateSkuSpecification
            {
                /// <summary>
                /// Constructor.
                /// </summary>
                public UpdateSkuSpecificationApi()
                {
                }

                /// <summary>
                /// Constructor.
                /// </summary>
                /// <param name=""httpClient"">The <see cref=""HttpClient""/>.</param>
                public UpdateSkuSpecificationApi(HttpClient httpClient)
                    : base(httpClient)
                {
                }
            }
        }
    }
}
