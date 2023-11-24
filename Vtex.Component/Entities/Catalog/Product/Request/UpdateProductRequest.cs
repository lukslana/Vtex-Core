using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Common.Extensions;
using Vtex.Component.Entities.Interfaces;

namespace Vtex.Component.Entities.Catalog.Product.Request
{
    public class UpdateProductRequest : BaseProductRequest, IRequestJsonPut
    {
        public override string BaseUrl => "api/catalog/pvt/product/{productId}";

        /// <summary>
        /// Product’s unique numerical identifier.
        /// </summary>
        public int productId { get; set; }

        /// <summary>
        /// Product's name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Department ID according to the product's category.
        /// </summary>
        public int DepartmentId { get; set; }

        /// <summary>
        /// Category ID associated with this product.
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// Brand ID associated with this product.
        /// </summary>
        public int BrandId { get; set; }

        /// <summary>
        /// Slug that will be used to build the product page URL. If it not informed, it will be generated according to the product's name replacing spaces and special characters by hyphens (-)
        /// </summary>
        public string LinkId { get; set; }

        /// <summary>
        /// Product Reference Code.
        /// </summary>
        public string RefId { get; set; }

        /// <summary>
        /// Shows (true) or hides (false) the product in search result and product pages, but the product can still be added to the shopping cart. Usually applicable for gifts.
        /// </summary>
        public bool IsVisible { get; set; }

        /// <summary>
        /// Product description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Short product description. This information can be displayed on both the product page and the shelf, using the following controls:
        /// <br></br>Store Framework: $product.DescriptionShort.
        /// <br></br>Legacy CMS Portal: <vtex.cmc:productDescriptionShort/>.
        /// </summary>
        public string DescriptionShort { get; set; }

        /// <summary>
        /// Used to assist in the ordering of the search result of the site. Using the O=OrderByReleaseDateDESC query string, you can pull this value and show the display order by release date. This attribute is also used as a condition for dynamic collections.
        /// </summary>
        public DateTime ReleaseDate { get; set; }

        /// <summary>
        /// Store Framework: Deprecated.
        /// Legacy CMS Portal: Keywords or synonyms related to the product, separated by comma(,). "Television", for example, can have a substitute word like "TV". This field is important to make your searches more comprehensive.
        /// </summary>
        public string KeyWords { get; set; }

        /// <summary>
        /// Product's Title tag. Is presented in the browser tab and corresponds to the title of the product page. This field is important for SEO.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Activate (true) or inactivate (false) product.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Product tax code, used for tax calculation.
        /// </summary>
        public string TaxCode { get; set; }

        /// <summary>
        /// Brief description of the product for SEO. It is recommended not to exceed 150 characters.
        /// </summary>
        public string MetaTagDescription { get; set; }

        /// <summary>
        /// SupplierId
        /// </summary>
        public int? SupplierId { get; set; }

        /// <summary>
        /// If true, activates the Notify Me option when the product is out of stock.
        /// </summary>
        public bool ShowWithoutStock { get; set; }

        /// <summary>
        /// AdWordsRemarketingCode
        /// </summary>
        public object AdWordsRemarketingCode { get; set; }

        /// <summary>
        /// LomadeeCampaignCode
        /// </summary>
        public object LomadeeCampaignCode { get; set; }

        /// <summary>
        /// Value used to set the priority on the search result page.
        /// </summary>
        public int? Score { get; set; }


        public override IList<KeyValuePair<string, string>> GetQueryStringWithoutParameters()
        {
            this.DataJsonPost = this;
            var parameters = base.GetQueryStringParameters();
            parameters.Add("productId", this.productId.ToString());
            return parameters;
        }
    }
}
