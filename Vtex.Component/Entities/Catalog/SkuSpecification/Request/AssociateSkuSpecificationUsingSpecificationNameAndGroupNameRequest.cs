using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Common.Extensions;

namespace Vtex.Component.Entities.Catalog.SkuSpecification.Request
{
    public class AssociateSkuSpecificationUsingSpecificationNameAndGroupNameRequest : BaseCatalogRequest
    {
        protected internal override string BaseUrl => "api/catalog/pvt/stockkeepingunit/{skuId}/specificationvalue";
        public override HttpMethod HttpMethod => HttpMethod.Put;

        /// <summary>
        /// SKU’s unique numerical identifier.
        /// </summary>
        public int SkuId { get; set; }

        /// <summary>
        /// Specification name. Limited to 100 characters.
        /// </summary>
        public string FieldName { get; set; }

        /// <summary>
        /// Group name.
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// Root level specification.
        /// </summary>
        public bool RootLevelSpecification { get; set; }

        /// <summary>
        /// Root level specification. <br></br>
        /// ⮕ [ Specification value. ]
        /// </summary>
        public string[] FieldValues { get; set; }


        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();
            parameters.Add("skuId", this.SkuId.ToString());
            return parameters;
        }
    }
}

