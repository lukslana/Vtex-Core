using Vtex.Component.Entities.Common.Extensions;
using Vtex.Component.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Catalog.Category.Request
{
    /// <summary>
    /// Creates a new Category.
    /// </summary>
    public class CreateCategoryRequest : BaseCatalogRequest
    {
        protected internal override string BaseUrl => "api/catalog/pvt/category";

        /// <summary>
        /// Category ID
        /// </summary>
        public int? categoryId { get; set; }

        /// <summary>
        /// Category Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// ID of the father category, apply in case of category and subcategory
        /// </summary>
        public int FatherCategoryId { get; set; }

        /// <summary>
        /// Category Title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Describes details about the Category
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Substitutes words for the Category
        /// </summary>
        public string Keywords { get; set; }

        /// <summary>
        /// Shows if the Category is active or not
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Shows the specific code for the LomadeeCampaign
        /// </summary>
        public string LomadeeCampaignCode { get; set; }

        /// <summary>
        /// Shows the specific code for the AdWords remarketing platform
        /// </summary>
        public string AdWordsRemarketingCode { get; set; }

        /// <summary>
        /// Shows if is on side and upper menu
        /// </summary>
        public bool ShowInStoreFront { get; set; }

        /// <summary>
        /// If Category has Brand filter
        /// </summary>
        public bool ShowBrandFilter { get; set; }

        /// <summary>
        /// If the Category has an active link on the website
        /// </summary>
        public bool ActiveStoreFrontLink { get; set; }

        /// <summary>
        /// Google Global Category ID
        /// </summary>
        public int GlobalCategoryId { get; set; }

        /// <summary>
        /// Shows how the SKU will be exhibit
        /// </summary>
        public string StockKeepingUnitSelectionMode { get; set; }
        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();
            parameters.Add("categoryId", this.categoryId.ToString());
            return parameters;
        }
    }
}
