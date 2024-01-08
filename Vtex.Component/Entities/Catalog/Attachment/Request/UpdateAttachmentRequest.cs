using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Common.Extensions;

namespace Vtex.Component.Entities.Catalog.Attachment.Request
{
	public class UpdateAttachmentRequest: BaseCatalogRequest
	{
		protected internal override string BaseUrl => "api/catalog/pvt/attachment/{attachmentid}";
		public override HttpMethod HttpMethod => HttpMethod.Put	;
		public int Attachmentid { get; set; }
		public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
		{
			var parameters = base.GetQueryStringParameters();
			parameters.Add("attachmentid", this.Attachmentid.ToString());
			return parameters;
		}
	}
}
