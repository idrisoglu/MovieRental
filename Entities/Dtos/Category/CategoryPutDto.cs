﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class CategoryPutDto
    {
        public Guid Id { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}
