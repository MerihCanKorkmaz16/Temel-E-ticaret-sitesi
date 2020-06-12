using CoreShopping.Northwind.Entities.Concrete;
using System.Collections.Generic;

namespace CoreShopping.Northwind.MvcWebUI
{
    public class ProductListViewModel
    {
        public List<Product> Products { get; internal set; }
        public int PageCount { get; internal set; }
        public int PageSize { get; internal set; }
        public int CurrentCategory { get; internal set; }
        public int CurrentPage { get; internal set; }
    }
}