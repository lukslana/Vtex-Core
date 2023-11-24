using System.Collections.Generic;
using Newtonsoft.Json;

namespace Vtex.Component.Entities.Catalog.Product.Response
{
    public class GetProductAndSkuIdsResponse : BaseResponse
    {
        /// <summary>
        /// "routes" contains an array of routes from the origin to the destination. See Routes below.
        /// </summary>
        [JsonProperty("")]
        //public virtual string data { get; set; }

        public string data { get; set; }
        public Range range { get; set; }

        public class Range
        {
            public int total { get; set; }
            public int from { get; set; }
            public int to { get; set; }
        }

    }

}
