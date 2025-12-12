using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using WebUI.Models;
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
            TempData.Add("message",String.Format("{0} --> ürün sepete eklendi",productToBeAdded.ProductName));
           return  RedirectToAction("Index","Product");

        }

        public ActionResult List()
        {
           var cart = _cartSessionService.GetCart();
            CartListViewModel cartListViewModel = new CartListViewModel()
            {
                Cart = cart
            };
            return View(cartListViewModel);
        }


    }

}

