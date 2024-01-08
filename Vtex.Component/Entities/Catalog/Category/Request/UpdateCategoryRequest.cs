using Vtex.Component.Entities.Common.Extensions;
using Vtex.Component.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Catalog.Category.Request
{
    [DataContract]
    /// <summary>
    /// Updates a previously existing Category.
    /// </summary>
    public class UpdateCategoryRequest : BaseCatalogRequest
    {
		protected internal override string BaseUrl => "api/catalog/pvt/category/{Id}";

        [JsonIgnore]
        public int Id { get; set; }

        [DataMember]
        /// <summary>
        /// Category Name
        /// </summary>
        public string Name { get; set; }

        [DataMember]
        /// <summary>
        /// Substitutes words for the Category
        /// </summary>
        public string Keywords { get; set; }

        [DataMember]
        /// <summary>
        /// Category Title
        /// </summary>
        public string Title { get; set; }

        [DataMember]
        /// <summary>
        /// Describes details about the Category
        /// </summary>
        public string Description { get; set; }

        [DataMember]
        /// <summary>
        /// This is a legacy field. Do not take this information into consideration.
        /// </summary>
        public string? AdWordsRemarketingCode { get; set; } = "";

        [DataMember]
        /// <summary>
        /// This is a legacy field. Do not take this information into consideration.
        /// </summary>
        public string LomadeeCampaignCode { get; set; } = "";

        [DataMember]
        /// <summary>
        /// ID of the father category, apply in case of category and subcategory
        /// </summary>
        public int FatherCategoryId { get; set; }

        [DataMember]
        /// <summary>
        /// Google Global Category ID
        /// </summary>
        public int GlobalCategoryId { get; set; }

        [DataMember]
        /// <summary>
        /// Shows if is on side and upper menu
        /// </summary>
        public bool ShowInStoreFront { get; set; }

        [DataMember]
        /// <summary>
        /// Shows if the Category is active or not
        /// </summary>
        public bool IsActive { get; set; }

        [DataMember]
        /// <summary>
        /// If the Category has an active link on the website
        /// </summary>
        public bool ActiveStoreFrontLink { get; set; }

        [DataMember]
        /// <summary>
        /// If Category has Brand filter
        /// </summary>
        public bool ShowBrandFilter { get; set; }

        [DataMember]
        /// <summary>
        /// Score for search ordination
        /// </summary>
        public int? Score { get; set; } = null;

        [DataMember]
        /// <summary>
        /// Shows how the SKU will be exhibit
        /// </summary>
        public string? StockKeepingUnitSelectionMode { get; set; } = null;

        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();
            parameters.Add("Id", this.Id.ToString());
            return parameters;
        }
    }
}
