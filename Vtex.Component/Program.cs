using System;
using Vtex.Component.Entities.Catalog.Product.Request;
using Vtex.Component.Entities.Catalog.SKU.Request;
using Vtex.Component.Entities.Order.Order.Request;
using Vtex.Component.Entities.Order.Order.Response;
using Vtex.Component.Entities.GiftCard.GiftCard.Request;
using Vtex.Component.Entities.GiftCard.GiftCard.Response;
using Newtonsoft.Json;
using Vtex.Component.Entities.Catalog.SKU.Response;
using System.Collections.Generic;
using Vtex.Component.Entities.Search.Search.Request;
using Vtex.Component;

namespace Vtex.Componentes.Remoto.Vtexssss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var getProductbyIDRequest = new GetProductbyIDRequest
            //{
            //    productId = "1263689"
            //};
            //var getProductbyIDResponde = VtexCatalog.GetProductbyID.Query(getProductbyIDRequest);

            //var getOrderByIDRequest = new GetOrderByIDRequest
            //{
            //    orderId = "1235803384406-01"
            //};
            //var getOrderByIDResponse = VtexOrder.GetOrderByID.Query(getOrderByIDRequest);

            //var listOrdersRequest = new ListOrdersRequest
            //{
            //    q = "lucasflana@gmail.com"
            //};
            //var listOrdersResponse = VtexOrder.ListOrders.Query(listOrdersRequest);


            //var getGiftCardbyIDRequest = new GetGiftCardbyIDRequest
            //{
            //    giftCardID = "12"
            //};
            //
            //var getGiftCardbyIDResponse = VtexGiftCard.GetGiftCardbyID.Query(getGiftCardbyIDRequest);

            //var rawJson = @"{""data"":[71001,81001,91001,101001,111001,131001,141001,192001,222001,251001,271001,281001,291001,301001,311001,331001,341001,352001,371001,381001401001,421001,441001,451001,461001]}";
            //var response = JsonConvert.DeserializeObject<ListAllSKUIDsResponse>(rawJson);
            //var searchForProductsRequest = new SearchForProductsRequest
            //{
            //    search = "dipirona"
            //};
            //
            //var searchForProductsResponse = VtexSearch.SearchForProducts.Query(searchForProductsRequest);

            //var searchForProductsWithFilterRequest = new SearchForProductsWithFilterRequest
            //{
            //    ft = "dipirona",
            //    fqCategory = new int[] { 2 },
            //    _from = 0,
            //    _to = 49
            //};
            //var searchForProductsWithFilterResponse = VtexSearch.SearchForProductsWithFilter.Query(searchForProductsWithFilterRequest);
        }
    }
}
