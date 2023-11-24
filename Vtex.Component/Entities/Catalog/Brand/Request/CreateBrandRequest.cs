
namespace Vtex.Component.Entities.Catalog.Brand.Request
{

    /// <summary>
    /// Create a new Brand and return an ID 
    /// </summary>
    public class CreateBrandRequest : BaseCatalogRequest
    {
        protected internal override string BaseUrl => "api/catalog/pvt/brand";
        public override HttpMethod HttpMethod => HttpMethod.Post;  

        /// <summary>
        /// Brand’s numerical identifier
        /// </summary>
        public virtual int Id { get; set; }

        /// <summary>
        /// Brand’s name
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// Brand’s description
        /// </summary>
        public virtual string Text { get; set; }

        /// <summary>
        /// Substitutes words for the Brand
        /// </summary>
        public virtual string Keywords { get; set; }

        /// <summary>
        /// Brand’s page title
        /// </summary>
        public virtual string SiteTitle { get; set; }

        /// <summary>
        /// If the Brand is active
        /// </summary>
        public virtual bool Active { get; set; }

        /// <summary>
        /// If the Brand shows on the home menu or not
        /// </summary>
        public virtual bool MenuHome { get; set; }

        /// <summary>
        /// Shows the specific code for the AdWords remarketing platform
        /// </summary>
        public virtual string AdWordsRemarketingCode { get; set; }

        /// <summary>
        /// Shows the specific code for the LomadeeCampaig
        /// </summary>
        public string LomadeeCampaignCode { get; set; }

        /// <summary>
        /// Score for search ordination
        /// </summary>
        public virtual int Score { get; set; }

        /// <summary>
        /// Brand’s link ID
        /// </summary>
        public virtual string LinkId { get; set; }
    }
}
