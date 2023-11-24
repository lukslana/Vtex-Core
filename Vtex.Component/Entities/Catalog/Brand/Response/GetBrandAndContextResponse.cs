using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Catalog.Brand.Response
{
    public class GetBrandAndContextResponse: BaseResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public string Keywords { get; set; }
        public string SiteTitle { get; set; }
        public bool Active { get; set; }
        public bool MenuHome { get; set; }
        public string AdWordsRemarketingCode { get; set; }
        public string LomadeeCampaignCode { get; set; }
        public int? Score { get; set; } = null;
        public string LinkId { get; set; }
    }
}
