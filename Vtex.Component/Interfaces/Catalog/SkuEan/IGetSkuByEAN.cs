using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Catalog.SkuEan.Request;
using Vtex.Component.Entities.Catalog.SkuEan.Response;

namespace Vtex.Component.Interfaces.Catalog.SkuEan
{
	public interface IGetSkuByEAN : IApi<GetSkuByEANRequest, GetSkuByEANResponse>
	{
	}
}
