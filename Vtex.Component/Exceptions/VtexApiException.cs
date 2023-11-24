using System;
using Vtex.Component.Entities.Common.Enums;

namespace Vtex.Component.Exceptions
{

    /// <summary>
    /// Exception that is thrown when Vtex returns a status code 
    /// </summary>
    public class VtexApiException : Exception
    {
        /// <summary>
        /// Status.
        /// </summary>
        public virtual Status? Status { get; set; }


        /// <summary>
        /// Constructor, accepting a error message and a optional status.
        /// </summary>
        /// <param name="message">The error message.</param>
        public VtexApiException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Constructor, accepting a error message and a optional status.
        /// </summary>
        /// <param name="message">The error message.</param>
        /// <param name="innerException">The inner exception.</param>
        public VtexApiException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
