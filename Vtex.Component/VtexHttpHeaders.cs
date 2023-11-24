using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component
{
    internal class VtexHttpHeaders
    {
        /// <summary>
        /// Use the appKey and appToken credential pair to authenticate API requests by sending their values in these HTTP headers:
        /// </summary>
        internal const string API_AppKey = "X-VTEX-API-AppKey";

        /// <summary>
        /// Use the appKey and appToken credential pair to authenticate API requests by sending their values in these HTTP headers:
        /// </summary>
        internal const string API_AppToken = "X-VTEX-API-AppToken";
    }
}
