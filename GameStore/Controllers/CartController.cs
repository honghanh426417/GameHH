using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GameStore.Data;
using GameStore.Models;
using GameStore.Infrastructure;

namespace GameStore.Controllers
{
    public class CartController : Controller
    {

        public Cart? Cart { get; set; }
        private readonly GameStoreContext _context;

        public CartController(GameStoreContext context)
        {
            _context = context;

        }

        // GET: /<controller>/
        public IActionResult AddToCart(int Id)
        {
            Product? product = _context.Products
                .FirstOrDefault(p => p.Id == Id);
            if ( product != null)
            {
                Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
                Cart.AddItem(product, 1);
                HttpContext.Session.SetJson("cart", Cart);
            }
            return View("Cart", Cart);
        }

        public IActionResult RemoveFromCart(int Id)
        {
            Product? product = _context.Products
                .FirstOrDefault(p => p.Id == Id);
            if (product != null)
            {
                Cart = HttpContext.Session.GetJson<Cart>("cart") ;
                Cart.RemoveLine(product);
                HttpContext.Session.SetJson("cart", Cart);
            }
            return View("Cart", Cart);
        }

        
    }
}

