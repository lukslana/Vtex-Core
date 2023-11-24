using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities
{
    /// <summary>
    /// Base Response Stream.
    /// </summary>
    public class BaseResponseStream : BaseResponse
    {
        /// <summary>
        /// Buffer.
        /// </summary>
        public virtual byte[] Buffer { get; set; }

        /// <summary>
        /// Stream.
        /// </summary>
        public virtual MemoryStream Stream => new(this.Buffer ?? Array.Empty<byte>());

    }
}
