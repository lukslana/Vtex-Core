using Vtex.Component.Entities.Common.Extensions;
using Vtex.Component.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Catalog.SkuEan.Request
{
    public class DeleteAllSkuEanValuesRequest : BaseSKUEanRequest
    {
		protected internal override string BaseUrl => "api/catalog/pvt/stockkeepingunit/{skuId}/ean";
		public override HttpMethod HttpMethod => HttpMethod.Delete;

		/// <summary>
		/// SKU's unique numerical identifier.
		/// </summary>
		public int SkuId { get; set; }

		public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
		{
			var parameters = base.GetQueryStringParameters();
			parameters.Add("skuId", this.SkuId.ToString());
			return parameters;
		}
    }
}
