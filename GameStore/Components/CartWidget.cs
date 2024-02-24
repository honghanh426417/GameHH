using System;
using GameStore.Data;
using GameStore.Infrastructure;
using GameStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.Components
{
	public class CartWidget:ViewComponent
	{
       
        public IViewComponentResult Invoke()
        {
            return View(HttpContext.Session.GetJson<Cart>("cart"));
        }
    }
}

