using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Catalog.Brand.Response
{
    public class GetBrandListPerPageResponse : BaseResponse
    {
        /// <summary>
        /// Array of objects with information of the store's brands.
        /// </summary>
        public Item[] items { get; set; }

        /// <summary>
        /// Object with information about the paging.
        /// </summary>
        public Paging paging { get; set; }
    
        public class Paging
        {
            /// <summary>
            /// Page number of the brand list.
            /// </summary>
            public int page { get; set; }
            /// <summary>
            /// Quantity of brands per page.
            /// </summary>
            public int perPage { get; set; }

            /// <summary>
            /// Total of brands in the store.
            /// </summary>
            public int total { get; set; }

            /// <summary>
            /// Total number of pages.
            /// </summary>
            public int pages { get; set; }
        }
        public class Item
        {
            /// <summary>
            /// Brand unique number identifier.
            /// </summary>
            public int id { get; set; }

            /// <summary>
            /// Brand name.
            /// </summary>
            public string name { get; set; }

            /// <summary>
            /// Condition if the brand is active or not.
            /// </summary>
            public bool isActive { get; set; }

            /// <summary>
            /// Title shown in the browser bar, which corresponds to the title of your page.
            /// </summary>
            public string title { get; set; }

            /// <summary>
            /// A brief description of the brand, displayed by search engines. Since search engines can only display less than 150 characters, we recommend not exceeding this character limit when creating the description.
            /// </summary>
            public string metaTagDescription { get; set; }

            /// <summary>
            /// Brand image URL.
            /// </summary>
            public object imageUrl { get; set; }
        }
    }
}
