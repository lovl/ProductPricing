﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPricing.Dto.Dtos
{
    public class ProductEditDto : ProductCreateDto
    {
        public long Id { get; set; }
    }
}