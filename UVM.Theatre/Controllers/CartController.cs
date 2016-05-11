using System.Linq;
using System.Web.Mvc;
using UVM.Theatre.Domain.Models;
using UVM.Theatre.Models;
using UVM.Theatre.Services;

namespace UVM.Theatre.Controllers
{
    public class CartController : Controller
    {
        private readonly IShowService _showService;
        private readonly IOrderProcessorService _orderProcessorService;

        public CartController(IShowService showService, IOrderProcessorService orderProcessorService)
        {
            _showService = showService;
            _orderProcessorService = orderProcessorService;
        }


        public ViewResult Index(Cart cart, string returnUrl)
        {
            return View(new CartIndex
            {
                ReturnUrl = returnUrl,
                Cart = cart
            });
        }

        public RedirectToRouteResult AddToCart(string returnUrl, Cart cart, int showId, int regularQuantity = 0, int seniorQuantity = 0, int studentQuantity = 0, int dateId = 0)
        {
            var show = _showService.GetShowById(showId);

            if (show == null) return RedirectToAction("Index", new {returnUrl});
            cart.AddItem(show, studentQuantity, regularQuantity, seniorQuantity);
            return RedirectToAction("Index", new { returnUrl });
        }

        public RedirectToRouteResult RemoveFromCart(Cart cart, int showId, int dateId, string returnUrl)
        {
            var show = _showService.GetShowById(showId);
            if (show == null) return RedirectToAction("Index", new {returnUrl});
            cart.RemoveLine(show);
            return RedirectToAction("Index", new { returnUrl });
        }

        public PartialViewResult Summary(Cart cart)
        {
            return PartialView(cart);
        }

        public ViewResult Checkout()
        {
            return View(new ShippingDetails());
        }

        [HttpPost]
        public ViewResult Checkout(Cart cart, ShippingDetails shippingDetails)
        {
            if (!cart.Lines.Any())
            {
                ModelState.AddModelError("", "Sorry, your cart is empty!");
            }

            if (ModelState.IsValid)
            {
                _orderProcessorService.ProcessOrder(cart, shippingDetails);
                cart.Clear();
                return View("Completed");
            }
            else
            {
                return View(shippingDetails);
            }
        }

    }
}