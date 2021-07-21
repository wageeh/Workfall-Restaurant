using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Oders.Entities;
using Orders.API.BAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orders.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private OrderManager ordersManager;
        public OrdersController(IHttpContextAccessor accessor)
        {
            ordersManager = new OrderManager(accessor.HttpContext);
        }

        [HttpGet]
        public ActionResult ListAsync()
        {
            List<Order> cart = ordersManager.ListAsync();
            return new OkObjectResult(cart);
        }


        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult CreateAsync(Order item)
        {
            if (ModelState.IsValid)
            {
                List<Order> cart = ordersManager.Append(item);
                return new OkObjectResult(cart);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
