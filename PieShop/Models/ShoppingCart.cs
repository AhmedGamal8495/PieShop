using Autofac.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Models
{
    public class ShoppingCart
    {
        private readonly AppDbContext _appDbContext;
        public string ShoppingCartId { get; set; }
        public List<ShoppingCartItem> shoppingCartItems { get; set; }

        public ShoppingCart(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public static ShoppingCart GetCart(IServiceProvider service)
        {
            ISession session = service.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;

            var context = service.GetService<AppDbContext>();

            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);

            return new ShoppingCart(context) { ShoppingCartId = cartId }; 

        }

        public void AddToCart(Pie pie , int Amount)
        {
            var shoppingCartItem = _appDbContext.ShoppingCartItems.SingleOrDefault(
                s => s.pie.PieId == pie.PieId && s.SoppingCartId == ShoppingCartId);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    SoppingCartId = ShoppingCartId,
                    pie = pie,
                    Amount = 1
                };
                _appDbContext.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }
            _appDbContext.SaveChanges();
        }

        public int RemoveFromCart(Pie pie)
        {
            var shoppingCartItem = _appDbContext.ShoppingCartItems.SingleOrDefault(
                s => s.pie.PieId == pie.PieId && s.SoppingCartId == ShoppingCartId);

            var localAmont = 0;
            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localAmont = shoppingCartItem.Amount;
                }
                else
                {
                    _appDbContext.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }
            _appDbContext.SaveChanges();
            return localAmont;
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return shoppingCartItems ??
                    (shoppingCartItems =
                      _appDbContext.ShoppingCartItems.Where(c => c.SoppingCartId == ShoppingCartId)
                        .Include(s => s.pie)
                        .ToList());
        }

        public void CleanCart()
        {
            var cartitem =
                  _appDbContext.ShoppingCartItems.Where(c => c.SoppingCartId == ShoppingCartId);

            _appDbContext.ShoppingCartItems.RemoveRange(cartitem);

            _appDbContext.SaveChanges();
                  
        }
        public decimal GetShoppingCartTotal()
        {
            var total =
                  _appDbContext.ShoppingCartItems.Where(c => c.SoppingCartId == ShoppingCartId).
                  Select(c => c.pie.Price * c.Amount).Sum();

            return total;
        }
    }
}
