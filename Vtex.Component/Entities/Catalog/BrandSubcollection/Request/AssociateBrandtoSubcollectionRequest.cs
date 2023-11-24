using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Common.Extensions;
using Vtex.Component.Entities.Interfaces;

namespace Vtex.Component.Entities.Catalog.BrandSubcollection.Request
{
    /// <summary>
    /// Associates a single Brand to a Subcollection, which is a Group within a Collection.
    /// </summary>
    public class AssociateBrandtoSubcollectionRequest : BaseBrandSubcollection, IRequestJsonPost
    {
        public override string BaseUrl => "api/catalog/pvt/subcollection/{subCollectionId}/brand";

        /// <summary>
        /// Subcollection’s unique numerical identifier, which can be obtained by placing a request to Get Subcollection by Collection ID.
        /// </summary>
        public int subCollectionId { get; set; }

        /// <summary>
        /// Unique identifier of a Brand.
        /// </summary>
        public int BrandId { get; set; }
        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();
            parameters.Add("BrandId", this.BrandId.ToString());
            return parameters;
        }
    }
}
