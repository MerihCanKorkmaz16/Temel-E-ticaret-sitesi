using CoreShopping.Northwind.Entities.Concrete;
using System.Collections.Generic;

namespace CoreShopping.Northwind.MvcWebUI.Model
{
    public class ProductUpdateViewModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}