using CoreShopping.Core.DataAccess.EntityFramework;
using CoreShopping.Northwind.DataAccess.Abstract;
using CoreShopping.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreShopping.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal:EfEntityRepositoryBase<Category,NorthwindContext>,ICategoryDal
    {
    }
}
