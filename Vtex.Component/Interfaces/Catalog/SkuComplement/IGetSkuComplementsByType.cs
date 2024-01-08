using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Catalog.SkuComplement.Request;
using Vtex.Component.Entities.Catalog.SkuComplement.Response;

namespace Vtex.Component.Interfaces.Catalog.SkuComplement
{
	public interface IGetSkuComplementsByType : IApi<GetSkuComplementsByTypeRequest, GetSkuComplementsByTypeResponse>
	{
	}
}
