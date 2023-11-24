using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Catalog.Brand.Response
{
    public class GetBrandListResponse: BaseResponse
    {
        public GetBrandListResponse Data { get; set; }

        /// <summary>
        /// id integer ID of the Brand
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// name string Name of the Brand
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// imageUrl    string Category Image URL
        /// </summary>
        public string imageUrl { get; set; }

        /// <summary>
        /// isActive boolean If the Brand is active
        /// </summary>
        public bool isActive { get; set; }

        /// <summary>
        /// title   string Meta Title for the Brand page
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// metaTagDescription  string Meta Description for the Brand page
        /// </summary>
        public string metaTagDescription { get; set; }
    }
}
