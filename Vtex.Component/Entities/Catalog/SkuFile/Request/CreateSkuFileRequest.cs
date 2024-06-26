﻿using Vtex.Component.Entities.Common.Extensions;
using Vtex.Component.Entities.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Catalog.SkuFile.Request
{
    public class CreateSkuFileRequest : BaseSkuFileRequest
    {
        internal protected override string BaseUrl => "api/catalog/pvt/stockkeepingunit/{skuId}/file";
        public override HttpMethod HttpMethod => HttpMethod.Post;

        [JsonIgnore]
        /// <summary>
        /// SKU's unique numerical identifier.
        /// </summary>
        public int SkuId { get; set; }

        /// <summary>
        /// Defines if the Image is the main image of the SKU.
        /// </summary>
        public bool IsMain { get; set; }

        /// <summary>
        /// SKU image label.
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// SKU image name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// General text of the image.
        /// </summary>
        public object Text { get; set; }

        /// <summary>
        /// External Image's URL. The URL must start with the protocol identifier (http:// or https://) and end with the file extension (.jpg, .png or .gif).
        /// </summary>
        public string Url { get; set; }

        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();
            parameters.Add("skuId", this.SkuId.ToString());
            return parameters;
        }
    }
}
