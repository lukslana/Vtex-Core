using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Interfaces
{

    /// <summary>
    /// Base interface for requests.
    /// </summary>
    public interface IRequest
    {
        /// <summary>
        /// Use the appKey and appToken credential pair to authenticate API requests by sending their values in these HTTP headers:
        /// </summary>
        string AppKey { get; set; }

        /// <summary>
        /// Use the appKey and appToken credential pair to authenticate API requests by sending their values in these HTTP headers:
        /// </summary>
        string AppToken { get; set; }

        /// <summary>
        /// Access the link, replacing the {{AccountName}} value with the name of your VTEX account.
        /// </summary>
        string AccountName { get; set; }

        /// <summary>
        /// Name of the VTEX account. Used as part of the URL.
        /// </summary>
        string Environment {  get; set; }
        object DataRequestBody { get; set; }

        HttpMethod HttpMethod { get; set; }  

        /// <summary>
        /// Returns the Uri for the request.
        /// </summary>
        /// <returns>The <see cref="Uri"/>.</returns>
        Uri GetUri();

        /// <summary>
        /// Get the query string collection of aggregated from all parameters added to the request.
        /// </summary>
        /// <returns>The <see cref="IList{KeyValuePair}"/> collection.</returns>
        IList<KeyValuePair<string, string>> GetQueryStringParameters();
    }
}
