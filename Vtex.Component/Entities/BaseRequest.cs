using Vtex.Component.Entities.Interfaces;
using Newtonsoft.Json;
using Vtex.Component.Entities.Common.Extensions;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Reflection.Metadata;

namespace Vtex.Component.Entities
{
    /// <summary>
    /// Base abstract class for requests.
    /// </summary>
    public abstract class BaseRequest : IRequest
    {
        /// <summary>
        /// Base Url (abstract).
        /// </summary>
        [JsonIgnore]
        protected internal abstract string BaseUrl { get; }

        public virtual string AppKey { get; set; }
        public virtual string AppToken { get; set; }
        public virtual string AccountName { get; set; }
        public virtual string Environment { get; set; }
        public virtual object DataRequestBody { get; set; } 

        [JsonIgnore]
        public virtual HttpMethod HttpMethod { get; set; }


        /// <summary>
        /// See <see cref="IRequest.GetUri()"/>.
        /// </summary>
        /// <returns>The <see cref="Uri"/>.</returns>
        public virtual Uri GetUri()
        {
            const string SCHEME = "https://";

            var queryStringParameters = this.GetQueryStringParameters()
                .Select(x =>
                    x.Value == null
                        ? Uri.EscapeDataString(x.Key)
                        : Uri.EscapeDataString(x.Key) + "=" + Uri.EscapeDataString(x.Value));
            var queryString = string.Join("&", queryStringParameters);

            var BaseUrlLocal = this.BaseUrl;
			foreach (var parameter in this.GetQueryStringParameters())
			{
				// Replace placeholders in the URL with actual values
				BaseUrlLocal = this.BaseUrl.ToLower().Replace("{" + parameter.Key.ToLower() + "}", parameter.Value);
			}

			if (!string.IsNullOrEmpty(queryString))
            {
                queryString = $"?{queryString}";
            }

            var uri = new Uri($"{SCHEME}{this.Environment}.vtexcommercestable.com.br/{BaseUrlLocal}{queryString}");

            if (this.AppKey == null)
            {
                return uri;
            }

            var url = $"{uri.LocalPath}{uri.Query}";

            var pathAndQueryBytes = Encoding.ASCII.GetBytes(uri.LocalPath + uri.Query);

            return new Uri($"{uri.Scheme}://{uri.Host}{url}");
        }

        /// <summary>
        /// See <see cref="IRequest.GetQueryStringParameters()"/>.
        /// </summary>
        /// <returns>The <see cref="IList{KeyValuePair}"/> collection.</returns>
        public virtual IList<KeyValuePair<string, string>> GetQueryStringParameters()
        {
            var parameters = new List<KeyValuePair<string, string>>();

            return parameters;
        }
    }
}
