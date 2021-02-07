﻿using System;
using System.Collections.Generic;
using System.Text;
using ReCapProject.Core.Entities;

namespace ReCapProject.Entities.Concrete
{
    public class Color:IEntity
    {
        public int ColorId { get; set; }
        public string ColorName { get; set; }
    }
}
