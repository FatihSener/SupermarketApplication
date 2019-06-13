using System;
using System.Collections.Generic;
using System.Text;
using MarketUygulamasi.Core.Entities;

namespace Market.Entities.Concrete
{
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
