﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore.Domain.Entities
{
    public class BookModelEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public double? Price { get; set; }
        public int? Quantity { get; set; }
    }
}
