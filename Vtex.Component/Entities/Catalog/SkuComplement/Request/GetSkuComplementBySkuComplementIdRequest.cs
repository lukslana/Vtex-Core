﻿using Vtex.Component.Entities.Common.Extensions;

namespace Vtex.Component.Entities.Catalog.SkuComplement.Request
{
    public class GetSkuComplementBySkuComplementIdRequest: BaseCatalogRequest
    {
        protected internal override string BaseUrl => "api/catalog/pvt/skucomplement/{skuComplementId}";
        public override HttpMethod HttpMethod => HttpMethod.Get;
        public int SkuComplementId { get; set; }

        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();
            parameters.Add("skuComplementId", this.SkuComplementId.ToString());
            return parameters;  
        }
    }
}
