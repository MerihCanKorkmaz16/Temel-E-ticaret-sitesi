using CoreShopping.Northwind.Entities.Concrete;
using CoreShopping.Northwind.MvcWebUI.Model;
using CoreShopping.Northwind.MvcWebUI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreShopping.Northwind.MvcWebUI.ViewComponents
{
    public class CartDetailsViewComponent : ViewComponent
    {
        private ICartSessionService _cartSessionService;

        public CartDetailsViewComponent(ICartSessionService cartSessionService)
        {
            _cartSessionService = cartSessionService;
        }

        public ViewViewComponentResult Invoke()
        {
            var model = new CartSummaryViewModel
            {
                Cart = _cartSessionService.GetCart()
            };
            return View(model);
        }
    }
}
