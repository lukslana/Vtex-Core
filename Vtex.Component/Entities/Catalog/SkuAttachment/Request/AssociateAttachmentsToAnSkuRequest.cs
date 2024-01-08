using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Catalog.SkuAttachment.Request
{
	public class AssociateAttachmentsToAnSkuRequest : BaseRequest
	{
		protected internal override string BaseUrl => "api/catalog/pvt/skuattachment";
		public override HttpMethod HttpMethod => HttpMethod.Post;
		public int SkuId { get; set; }
		public string[] AttachmentNames { get; set; }

	}
}
