﻿using System;
using System.Collections.Generic;
using System.Text;
using ReCapProject.Entities.Abstract;

namespace ReCapProject.Entities.Concrete
{
    public class Brand:IEntity
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
    }
}
