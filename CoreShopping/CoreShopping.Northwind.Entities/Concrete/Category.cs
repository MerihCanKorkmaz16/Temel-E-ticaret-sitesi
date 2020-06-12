using CoreShopping.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreShopping.Northwind.Entities.Concrete
{
   public  class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
