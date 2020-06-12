using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreShopping.Northwind.Business.Abstract;
using CoreShopping.Northwind.Entities.Concrete;
using CoreShopping.Northwind.MvcWebUI.Model;
using CoreShopping.Northwind.MvcWebUI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CoreShopping.Northwind.MvcWebUI.Controllers
{
    public class CartController : Controller
    {
        private ICartSessionService _cartSessionService;
        private ICartService _cartService;
        private IProductService _productService;

        public CartController(ICartSessionService cartSessionService, ICartService cartService, IProductService productService)
        {
            _cartSessionService = cartSessionService;
            _cartService = cartService;
            _productService = productService;
        }

        public IActionResult AddToCart(int productId)
        {
            var productToAdded = _productService.GetById(productId);
            var cart = _cartSessionService.GetCart();

            _cartService.AddToCart(cart,productToAdded);
            TempData.Add("message", String.Format("your product, {0} , was succesfully to the cart!", productToAdded.ProductName));
            _cartSessionService.SetCart(cart);
            return RedirectToAction("Index","Product");
        }

        public IActionResult List()
        {
            var cart = _cartSessionService.GetCart();
            CartSummaryViewModel cartListViewModel = new CartSummaryViewModel
            {
                Cart = cart
            };
            return View(cartListViewModel);
        }

        public ActionResult Remove(int productId)
        {
            var cart = _cartSessionService.GetCart();
            _cartService.RemoveFromCart(cart,productId);
            _cartSessionService.SetCart(cart);
            TempData.Add("message", String.Format("your product was succesfully removed to the cart!"));
            _cartSessionService.SetCart(cart);
            return RedirectToAction("List");
        }

        public ActionResult Complete()
        {
            var shippingDetailsViewModel = new ShippingDetailsViewModel
            {
                ShippingDetails = new ShippingDetails()
            };
            return View(shippingDetailsViewModel);
        }
        [HttpPost]
        public ActionResult Complete(ShippingDetails shippingDetails)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            TempData.Add("message", String.Format("Thank you! {0}",shippingDetails.FirstName));
            return View();
        }

    }
}
