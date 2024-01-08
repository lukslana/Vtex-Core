using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Catalog.SkuAttachment.Request
{

	public class DissociateAttachmentsAndSkusRequest : BaseRequest
	{
		protected internal override string BaseUrl => "api/catalog/pvt/skuattachment";
		public override HttpMethod HttpMethod => HttpMethod.Delete;
		public int AttachmentId { get; set; }
		public int SkuId { get; set; }
	}
}
