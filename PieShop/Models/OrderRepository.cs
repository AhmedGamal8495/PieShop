using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Models
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;
        public OrderRepository(AppDbContext appDbContext , ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
            _appDbContext = appDbContext;
        }
        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;
            _appDbContext.Orders.Add(order);
            _appDbContext.SaveChanges();
            var shoppingCartItems = _shoppingCart.shoppingCartItems;

            foreach (var shoppingCartItem in shoppingCartItems)
            {
                var orderDetails = new OrderDetails()
                {
                    Amount = shoppingCartItem.Amount,
                    PieId = shoppingCartItem.pie.PieId,
                    OrderId = order.Id,
                    Price = shoppingCartItem.pie.Price
                };

                _appDbContext.OrderDetails.Add(orderDetails);
            }

            _appDbContext.SaveChanges();
        }
    }
}
