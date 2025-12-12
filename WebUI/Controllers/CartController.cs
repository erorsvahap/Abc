using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using WebUI.Services;

namespace WebUI.Controllers
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

        public ActionResult AddToCart(int productId)
        {
           var productToBeAdded = _productService.GetById(productId);
           var cart = _cartSessionService.GetCart();
            _cartService.AddToCart(cart, productToBeAdded);
            _cartSessionService.SetCart(cart);
            TempData.Add("message",String.Format("{0} has been added to cart!",productToBeAdded.ProductName));
           return  RedirectToAction("Index","Product");

        }


    }

}

