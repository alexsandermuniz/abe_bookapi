using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BookStoreApi.Business;
using Newtonsoft.Json;
using BookStoreApi.Entities;

namespace BookStoreApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        public string URL_TRANS = "http://localhost:4011/cardsapi/v1/Transactions";
        public string URL_AUDIT = "http://localhost:4013/auditsapi/v1/Records";
        public string URL_AUTH  = "http://localhost:4000//v1/authentication";
        OrderBusiness _OrderBusiness = new OrderBusiness();
        // POST api/orders
        [HttpPost]
        public ActionResult<long>  Post([FromBody] Order order)
        {
            //CallApi.GetRequest(URL_AUTH);

            string TRANS_DATA = JsonConvert.SerializeObject(new Transaction(0,order.totalValue,order.time));
            CallApi.PostRequest(TRANS_DATA, URL_TRANS);

            long idCreated =  _OrderBusiness.createOrder(order);

            string AUDITS_DATA = JsonConvert.SerializeObject(new Record(order.userName, order.store, order.time, order.totalValue, order.location));
            CallApi.PostRequest(AUDITS_DATA, URL_AUDIT);

            return idCreated;
        }
          // GET api/orders/{orderId}
        [HttpGet("{orderId}")]
        public ActionResult<Order> Get(long orderId)
        {
            return _OrderBusiness.getOrder(orderId);
        }
    }
}
