using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Catalog.SkuFile.Response
{
    public class CreateSkuFileResponse : BaseResponse
    {
        public int Id { get; set; }
        public int ArchiveId { get; set; }
        public int SkuId { get; set; }
        public bool IsMain { get; set; }
        public string Label { get; set; }
    }
}
