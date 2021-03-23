using System;
using System.Collections.Generic;
using System.Text;
using ReCapProject.Core.Entities;

namespace ReCapProject.Entities.Concrete
{
    public class FakeCard:IEntity
    {
        public int Id { get; set; }
        public string CardName { get; set; }
        public string CardNumber { get; set; }
        public string CardCvv { get; set; }
        public decimal MoneyInTheCard { get; set; }
        public string ExpirationDate { get; set; }
    }
}
