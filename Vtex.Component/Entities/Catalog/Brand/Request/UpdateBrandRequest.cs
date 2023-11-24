using Vtex.Component.Entities.Common.Extensions;
using Vtex.Component.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Catalog.Brand.Request
{

    /// <summary>
    /// Retrieves all Brands registered in the store's Catalog.
    /// </summary>
    public class UpdateBrandRequest : BaseCatalogRequest
    {
        protected internal override string BaseUrl => "api/catalog/pvt/brand/{Id}";

        public override HttpMethod HttpMethod => HttpMethod.Put;

        /// <summary>
        /// Brand’s numerical identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Brand’s name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Brand’s description
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Substitutes words for the Brand
        /// </summary>
        public string Keywords { get; set; }

        /// <summary>
        /// Brand’s page title
        /// </summary>
        public string SiteTitle { get; set; }

        /// <summary>
        /// If the Brand is active
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// If the Brand shows on the home menu or not
        /// </summary>
        public bool MenuHome { get; set; }

        /// <summary>
        /// Shows the specific code for the AdWords remarketing platform
        /// </summary>
        public string AdWordsRemarketingCode { get; set; }

        /// <summary>
        /// Shows the specific code for the LomadeeCampaig
        /// </summary>
        public string LomadeeCampaignCode { get; set; }

        /// <summary>
        /// Score for search ordination
        /// </summary>
        public int Score { get; set; }

        /// <summary>
        /// Brand’s link ID
        /// </summary>
        public string LinkId { get; set; }
        
        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();
            parameters.Add("Id", this.Id.ToString());
            return parameters;
        }
    }

}
