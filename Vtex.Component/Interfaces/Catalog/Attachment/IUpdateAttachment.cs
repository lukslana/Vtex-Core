using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Catalog.Attachment.Request;
using Vtex.Component.Entities.Catalog.Attachment.Response;

namespace Vtex.Component.Interfaces.Catalog.Attachment
{
	public interface IUpdateAttachment : IApi<UpdateAttachmentRequest, UpdateAttachmentResponse>
	{
	}
}
