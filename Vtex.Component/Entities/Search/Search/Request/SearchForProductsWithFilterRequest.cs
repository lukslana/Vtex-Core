using Vtex.Component.Entities.Common.Extensions;
using Vtex.Component.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Search.Search.Request
{
    public class SearchForProductsWithFilterRequest : BaseRequest
    {
        protected internal override string BaseUrl => "api/catalog_system/pub/products/search/";

        /// <summary>
        /// Filter by full text - ft={searchWord} <br></br>
        /// Ex: ft=television 
        /// </summary>
        public string? ft { get; set; } = null;

        /// <summary>
        /// Filter by category - fq=C:/{a}/{b} <br></br>
        ///{a} and {b} are categoryIds <br></br>
        ///Ex: fq=C:/1000041/1000049/ <br></br>
        /// </summary>
        public int[]? fqCategory { get; set; } = null;

        /// <summary>
        ///Filter by brand - fq=B:/{a}/{b}
        ///{a} and {b} are brandIds
        ///Ex: fq=B:/189385/189387/
        /// </summary>
        public int[]? fqBrand { get; set; } = null;

        /// <summary>
        ///Filter by specification - fq=specificationFilter_{a}:{b}
        ///{a} is the specificationId, {b} = specification value
        ///Ex: To filter products where the color is Blue, find the specificationId for color, supose it's 123 then it will be like this fq=specificationFilter_123:Blue
        /// </summary>
        public Dictionary<int, string>? fqSpecification { get; set; } = null;

        /// <summary>
        ///Filter by price range - fq=P:[{a} TO {b}]
        ///{a} is the minimum price "from" and {b} is the highest price "to"
        ///Ex: fq=P:[0 TO 20] will search products between 0.00 and 20.00.
        /// </summary>
        public string fqRange { get; set; }

        /// <summary>
        ///Filter by collection - fq=productClusterIds:{{productClusterId}}
        ///where productClusterId also know as collectionId
        ///More information about collections: https://help.vtex.com/en/tutorial/creating-a-product-collection
        /// </summary>
        public string fqCollection { get; set; }


        /// <summary>
        ///Filter by product Id - fq=productId:{{productId}}
        /// </summary>
        public int? fqProductId { get; set; } = null;

        /// <summary>
        ///Filter by sku Id - fq=skuId:{{skuId}}
        /// </summary>
        public string fqSkuId { get; set; }


        /// <summary>
        ///Filter by referenceId - fq=alternateIds_RefId:{{referenceId}}
        /// </summary>
        public string fqReferenceId { get; set; }


        /// <summary>
        ///Filter by ean13 - fq=alternateIds_Ean:{{ean13}}
        /// </summary>
        public string? fqEan13 { get; set; } = null;

        /// <summary>
        ///Filter by availability at a specific sales channel - fq=isAvailablePerSalesChannel_{{sc}}:{{bool}}
        /// </summary>
        public string fqAvailability { get; set; }

        /// <summary>
        /// Initial item number
        /// </summary>
        public int? _from { get; set; } = null;

        /// <summary>
        /// Final item number 
        /// </summary>
        public int? _to { get; set; } = null;

        /// <summary>
        ///Price                         <br></br> 
        ///O = OrderByPriceDESC          <br></br>
        ///O=OrderByPriceASC             <br></br>
        ///                              <br></br>
        ///Top Selling Products          <br></br>
        ///O=OrderByTopSaleDESC          <br></br>
        ///                              <br></br>
        ///Best Reviews                  <br></br>
        ///O=OrderByReviewRateDESC       <br></br>
        ///                              <br></br>
        ///Name                          <br></br>
        ///O = OrderByNameASC            <br></br>
        ///O=OrderByNameDESC             <br></br>
        ///                              <br></br>
        ///Release Date                  <br></br>
        ///O=OrderByReleaseDateDESC      <br></br>
        ///                              <br></br>
        ///Best Discounts                <br></br>
        ///O=OrderByBestDiscountDESC     <br></br>
        ///                              <br></br>
        ///Score                         <br></br>
        ///O=OrderByScoreDESC            <br></br>
        /// </summary>
        public string OrderBy { get; set; }

        public override IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = base.GetQueryStringParameters();

            var parametersLocal = "";

            if (!(this.ft == null))
            {
                parameters.Add("ft", this.ft);
            }

            if (!(this.fqCategory == null))
            {
                parametersLocal += "C:";
                foreach (var item in fqCategory)
                {
                    parametersLocal += "/" + item.ToString() + "";
                }
                parametersLocal += "/";
            }

            if (!(this.fqBrand == null))
            {
                parametersLocal += "B:";
                foreach (var item in fqBrand)
                {
                    parametersLocal += "/" + item.ToString() + "";
                }
                parametersLocal += "/";
            }

            if (!(this.fqSpecification == null))
            {
                parametersLocal += "specificationFilter_";
                foreach (var item in fqSpecification)
                {
                    parametersLocal += item.Key + ":" + item.Value;
                }
            }
            if (!(this.fqProductId == null))
            {
                parametersLocal += "productId:" + this.fqProductId.ToString();
            }

            if (!(this.fqEan13 == null))
            {
                parametersLocal += "alternateIds_Ean:" + this.fqEan13.ToString();
            }    

            if (!(this._from == null))
            {
                parameters.Add("_from", this._from.ToString());
            }

            if (!(this._to == null))
            {
                parameters.Add("_to", this._to.ToString());
            }

            if (!(this.OrderBy == null))
            {
                parameters.Add("O", this.OrderBy.ToString());
            }

            if (!string.IsNullOrEmpty(parametersLocal.ToString()))
            {
                parameters.Add("fq", parametersLocal);
            }
            return parameters;
        }
    }
}
