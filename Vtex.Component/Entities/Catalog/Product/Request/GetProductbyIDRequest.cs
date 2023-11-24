﻿using System.Collections.Generic;
using Vtex.Component.Entities.Common.Extensions;
using Vtex.Component.Entities.Interfaces;

namespace Vtex.Component.Entities.Catalog.Product.Request
{
    public class GetProductbyIDRequest : BaseProductRequest, IRequestQueryString
    {
        public override string BaseUrl => "api/catalog/pvt/product/{productId}";
        public virtual int productId { get; set; }

        public override IList<KeyValuePair<string, string>> GetQueryStringWithoutParameters()
        {
            var parameters = base.GetQueryStringWithoutParameters();

            if (!string.IsNullOrEmpty(this.productId.ToString()))
            {
                parameters.Add("productId", this.productId.ToString());
            }
            return parameters;
        }
    }
}
