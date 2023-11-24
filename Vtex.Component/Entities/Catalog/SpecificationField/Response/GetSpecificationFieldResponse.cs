﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Catalog.SpecificationField.Response
{
    public class GetSpecificationFieldResponse: BaseCatalogResponse
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int FieldId { get; set; }
        public bool IsActive { get; set; }
        public bool IsRequired { get; set; }
        public int FieldTypeId { get; set; }
        public string FieldTypeName { get; set; }
        public object FieldValueId { get; set; }
        public string Description { get; set; }
        public bool IsStockKeepingUnit { get; set; }
        public bool IsFilter { get; set; }
        public bool IsOnProductDetails { get; set; }
        public int Position { get; set; }
        public bool IsWizard { get; set; }
        public bool IsTopMenuLinkActive { get; set; }
        public bool IsSideMenuLinkActive { get; set; }
        public object DefaultValue { get; set; }
        public int FieldGroupId { get; set; }
        public string FieldGroupName { get; set; }
    }
}
