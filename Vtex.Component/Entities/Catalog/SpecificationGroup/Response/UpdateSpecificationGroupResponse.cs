﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Component.Entities.Catalog.SpecificationGroup.Response
{
    internal class UpdateSpecificationGroupResponse
    {
        public int CategoryId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Position { get; set; }
    }
}
