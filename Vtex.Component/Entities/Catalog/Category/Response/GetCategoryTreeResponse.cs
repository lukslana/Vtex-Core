using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Catalog.Category.Response
{
    public class GetCategoryTreeResponse : BaseCatalogResponse
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool hasChildren { get; set; }
        public string url { get; set; }
        public Child[] children { get; set; }
        public string Title { get; set; }
        public string MetaTagDescription { get; set; }
        public class Child
        {
            public int id { get; set; }
            public string name { get; set; }
            public bool hasChildren { get; set; }
            public string url { get; set; }
            public object[] children { get; set; }
            public string Title { get; set; }
            public string MetaTagDescription { get; set; }
        }
    }
}
