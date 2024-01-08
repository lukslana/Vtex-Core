using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Common.Extensions;

namespace Vtex.Component.Entities.Catalog.SkuAttachment.Request
{

	public class DeleteSkuAttachmentByAttachmentAssociationIDRequest : BaseRequest
	{
		protected internal override string BaseUrl => "api/catalog/pvt/skuattachment/{skuAttachmentAssociationId}";
		public override HttpMethod HttpMethod => HttpMethod.Delete;
		/// <summary>
		/// ID of the association between the attachment and the SKU, which corresponds to the Id in the response body of the Associate SKU attachment and the Get SKU attachment by SKU ID endpoints.
		/// </summary>
		public int SkuAttachmentAssociationId { get; set; }
		public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
		{
			var parameters = base.GetQueryStringParameters();
			parameters.Add("skuAttachmentAssociationId", this.SkuAttachmentAssociationId.ToString());
			return parameters;
		}
	}
}
