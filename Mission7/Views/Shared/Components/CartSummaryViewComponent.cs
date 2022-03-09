using System;
using Microsoft.AspNetCore.Mvc;
using Mission7.Models;
namespace Mission7.Views.Shared.Components
{
    public class CartSummaryViewComponent :ViewComponent
    {
        private Cart cart;

        public CartSummaryViewComponent(Cart c)
        {
            cart = c;
        }

        public IViewComponentResult Invoke()
        {
            return View(cart);
        }
    }
}
