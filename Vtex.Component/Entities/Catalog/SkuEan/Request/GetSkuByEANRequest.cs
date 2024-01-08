using Vtex.Component.Entities.Common.Extensions;
using Vtex.Component.Entities.Interfaces;

namespace Vtex.Component.Entities.Catalog.SkuEan.Request
{

    public class GetSkuByEANRequest : BaseSKUEanRequest
    {
		protected internal override string BaseUrl => "api/catalog_system/pvt/sku/stockkeepingunitbyean/{ean}";
		public override HttpMethod HttpMethod => HttpMethod.Get;

		/// <summary>
		/// Ean
		/// </summary>
		public int Ean { get; set; }

		public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
		{
			var parameters = base.GetQueryStringParameters();
			parameters.Add("ean", this.Ean.ToString());
			return parameters;
		}
    }
}
