using Microsoft.AspNetCore.Http;
using Oders.Entities;
using System;
using System.Collections.Generic;
using Orders.API.Helpers;

namespace Orders.API.BAL
{
    public class OrderManager
    {
        ISession session;
        public OrderManager(HttpContext context)
        {
            session = context.Session;
        }

        public List<Order> Append(Order newOrder)
        {
            newOrder.CreatedDate = DateTime.UtcNow.Date;
            newOrder.EntityId = Guid.NewGuid();
            newOrder.Branch = "Cairo";
            // here creating the partition as order branch and add it as static now for simplifying example
            List<Order> cart = session.GetObjectFromJson<List<Order>>("cart");
            if(cart == null)
            {
                cart = new List<Order>();
            }
            cart.Add(newOrder);
            session.SetObjectAsJson("cart", cart);
            return cart;
        }


        public List<Order> ListAsync()
        {
            List<Order> cart = session.GetObjectFromJson<List<Order>>("cart");
            if(cart == null)
            {
                cart = new List<Order>();
            }
            return cart;
        }
    }
}
