using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Catalog.SkuAttachment.Request;
using Vtex.Component.Entities.Catalog.SkuAttachment.Response;

namespace Vtex.Component.Interfaces.Catalog.SkuAttachment
{
	public interface IAssociateAttachmentsToAnSku : IApi<AssociateAttachmentsToAnSkuRequest, AssociateAttachmentsToAnSkuResponse>
	{
	}

}
