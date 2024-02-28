using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Catalog.SkuService.Request
{
    public class AssociateSkuServiceRequest: BaseSkuServiceRequest
    {
        internal protected override string BaseUrl => "api/catalog/pvt/skuservice";
        public override HttpMethod HttpMethod => HttpMethod.Put;

        /// <summary>
        /// SKU service unique identifier.
        /// </summary>
        public int SkuServiceId { get; set; }


        /// <summary>
        /// SKU service type ID.
        /// </summary>
        public int SkuServiceTypeId { get; set; }

        /// <summary>
        /// SKU service value ID.
        /// </summary>
        public int SkuServiceValueId { get; set; }

        /// <summary>
        /// SKU ID.
        /// </summary>
        public int SkuId { get; set; }

        /// <summary>
        /// SKU service name. Maximum of 50 characters.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Internal description for the SKU service. Maximum of 100 characters.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Defines if the SKU service is active or not.
        /// </summary>
        public bool IsActive { get; set; }

    }
}
