﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Catalog.SkuAttachment.Response
{
	public class AssociateSkuAttachmentResponse: BaseResponse
	{
		public int Id { get; set; }
		public int AttachmentId { get; set; }
		public int SkuId { get; set; }
	}	
}
