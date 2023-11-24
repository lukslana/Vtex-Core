﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Catalog.Specification.Request
{
    public class CreateSpecificationRequest : BaseCatalogRequest
    {
        protected internal override string BaseUrl => "api/catalog/pvt/specification";
        public override HttpMethod HttpMethod => HttpMethod.Post;
        public int FieldTypeId { get; set; }
        public int CategoryId { get; set; }
        public int FieldGroupId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Position { get; set; }
        public bool IsFilter { get; set; }
        public bool IsRequired { get; set; }
        public bool IsOnProductDetails { get; set; }
        public bool IsStockKeepingUnit { get; set; }
        public bool IsActive { get; set; }
        public bool IsTopMenuLinkActive { get; set; }
        public bool IsSideMenuLinkActive { get; set; }
        public string DefaultValue { get; set; }
    }
}
