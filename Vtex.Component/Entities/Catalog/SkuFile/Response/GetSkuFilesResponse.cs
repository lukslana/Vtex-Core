using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Catalog.SkuFile.Response
{
    public class GetSkuFilesResponse : BaseResponse
    {
        public data[] Data { get; set; }
     
        public class data
        {
            public int Id { get; set; }
            public int ArchiveId { get; set; }
            public int SkuId { get; set; }
            public string Name { get; set; }
            public bool IsMain { get; set; }
            public string Label { get; set; }
        }
    }
}
