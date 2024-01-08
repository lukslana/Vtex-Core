using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtex.Component.Entities.Common.Enums;

namespace Vtex.Component.Entities.Interfaces
{
    public interface IResponse
    {
        /// <summary>
        /// Raw json of the response.
        /// </summary>
        string RawJson { get; set; }

        /// <summary>
        /// Raw querystring of the request.
        /// </summary>
        string RawQueryString { get; set; }

        /// <summary>
        /// The status returned with the response.
        /// <see cref="Vtex.Component.Entities.Common.Enums.Status.Ok"/> indicates success.
        /// </summary>
        Status? Status { get; set; }

        /// <summary>
        /// When the status code is other than 'Ok', there may be an additional error_message field within the response object. 
        /// This field contains more detailed information about the reasons behind the given status code.
        /// Note: This field is not guaranteed to be always present, and its content is subject to change.
        /// </summary>
        string ErrorMessage { get; set; }

        string Message { get; set; }



        /// <summary>
        /// html_attributions contain a set of attributions which must be displayed to the user.
        /// </summary>
        IEnumerable<string> HtmlAttributions { get; set; }

        int _from { get; set; }
        int _to { get; set; }
        int _itensFounds { get; set; }
    }
}
