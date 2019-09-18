using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BookStoreApi.Business;

namespace BookStoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        OrderBusiness _OrderBusiness = new OrderBusiness();
        // POST api/orders
        [HttpPost]
        public ActionResult<long>  Post([FromBody] Order order)
        {
           return _OrderBusiness.createOrder(order);         
        }
          // GET api/orders/{orderId}
        [HttpGet("{orderId}")]
        public ActionResult<Order> Get(long orderId)
        {
            return _OrderBusiness.getOrder(orderId);
        }
    }
}
