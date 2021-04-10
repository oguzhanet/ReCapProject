using System;
using System.Collections.Generic;
using System.Text;
using ReCapProject.Core.Entities;

namespace ReCapProject.Entities.DTOs
{
    public class CarImageDto:IDto
    {
        public int CarId { get; set; }
        public string ImagePath { get; set; }
    }
}
