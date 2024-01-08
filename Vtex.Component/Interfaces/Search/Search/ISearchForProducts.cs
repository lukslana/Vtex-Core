using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Search.Search.Request;
using Vtex.Component.Entities.Search.Search.Response;


namespace Vtex.Component.Interfaces.Search.Search
{
	public interface ISearchForProducts : IApi<SearchForProductsRequest, SearchForProductsResponse>
	{
	}
}
