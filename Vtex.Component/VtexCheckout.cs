using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Checkout.CartAttachments.Request;
using Vtex.Component.Entities.Checkout.CartAttachments.Response;
using Vtex.Component.Entities.Checkout.ShoppingCart.Request;
using Vtex.Component.Entities.Checkout.ShoppingCart.Response;

namespace Vtex.Component
{
    /*
    /// <summary>
    ///The orderForm is the main object processed by VTEX checkout, and one of the most important data structures in the architecture of every VTEX store.
    ///<br></br>It stores a lot of contextual information about the order which is important to the processing of the order: order items, client's personal data, delivery address, freight information, etc.
    ///<br></br>Using VTEX APIs this information can be accessed, processed, and even changed on certain occasions.
    ///<br></br>VTEX's Checkout API is one of the main interfaces interacting with the orderForm object. Most of its operations will return the orderForm or part of it.
    /// </summary>
    public class VtexCheckout
    {
        /// <summary>
        /// This request allows you to obtain information of an existing shopping cart or to create a new empty one. VTEX checkout provides browsers with a cookie containing an orderFormId. Sending this request with such a cookie retrieves information of the cart corresponding to that ID. Without the cookie, this request creates and retrieves a new shopping cart.
        /// <br></br>The orderForm is the data structure which represents a shopping cart and contains all information pertaining to it.Hence, the orderFormId obtained in response is the identification code of the newly created cart.
        /// </summary>
        public static HttpEngine<GetCurrentCartOrCreateNewOneRequest, GetCurrentCartOrCreateNewOneResponse> GetCurrentCartOrCreateNewOne => HttpEngine<GetCurrentCartOrCreateNewOneRequest, GetCurrentCartOrCreateNewOneResponse>.instance;

        /// <summary>
        /// This request removes all items from a given cart, leaving it empty.
        /// </summary>
        public static HttpEngine<RemoveAllItemsRequest, RemoveAllItemsResponse> RemoveAllItems => HttpEngine<RemoveAllItemsRequest, RemoveAllItemsResponse>.instance;

        /// <summary>
        /// With the items update request you can: <br></br>
        /// Add items to the cart; <br></br>
        /// Change the quantity of one or more items in a specific cart; <br></br>
        /// Remove items from the cart(by changing their quantity to 0).  <br></br>
        /// The orderForm is the data structure which represents a shopping cart and contains all information pertaining to it.Hence, the orderFormId is the identification code of a given cart.
        /// </summary>
        public static HttpEngine<UpdateCartItemsRequest, UpdateCartItemsResponse> UpdateCartItems => HttpEngine<UpdateCartItemsRequest, UpdateCartItemsResponse>.instance;

        /// <summary>
        ///This endpoint is used for the merchant to add to the cart any relevant information that is related to the context of a specific order.
        ///The orderForm is the data structure which represents a shopping cart and contains all information pertaining to it. Hence, the orderFormId is the identification code of a given cart.
        /// </summary>
        public static HttpEngine<AddMerchantContextDataRequest, AddMerchantContextDataResponse> AddMerchantContextData => HttpEngine<AddMerchantContextDataRequest, AddMerchantContextDataResponse>.instance;


        public static HttpEngine<AddMarketingDataRequest, AddMarketingDataResponse> AddMarketingData => HttpEngine<AddMarketingDataRequest, AddMarketingDataResponse>.instance;


        /// <summary>
        /// Use this request to get all information associated to a given shopping cart.
        /// <br></br>
        /// The orderForm is the data structure which represents a shopping cart and contains all information pertaining to it.Hence, the orderFormId is the identification code of a given cart.
        /// </summary>
        public static HttpEngine<GetCartInformationByIDRequest, GetCartInformationByIDResponse> GetCartInformationByID => HttpEngine<GetCartInformationByIDRequest, GetCartInformationByIDResponse>.instance;
        
    }
    */
}
