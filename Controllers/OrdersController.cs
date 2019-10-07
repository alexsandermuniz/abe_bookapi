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
        //public string URL_AUTH  = "http://mock-authentication-api.appspot.com/auth/v1/api/authenticate";
        public string URL_AUTH = "http://localhost:8080/auth/v1/api/authenticate";
        OrderBusiness _OrderBusiness = new OrderBusiness();
        [HttpPost]
        public ActionResult<long>  Post([FromBody] Order order)
        {            
            string authorization = CallApi.GetRequest(URL_AUTH+ "?base64=" + order.authentication);
            if(authorization.Equals("ERROR"))
            {
                return BadRequest("Não foi possível autenticar o usuário, tente utilizar usuário padrão basicAuthentication: basic Encode64({ login:usuario1, password:teste123})");
            }

            if(!authorization.Equals("authorized"))
            {
                return BadRequest("Usuário inválido, tente utilizar usuário padrão: basic {login:usuario1, password:teste123}");
            }

            string TRANS_DATA = JsonConvert.SerializeObject(new Transaction(order.cardId, order.totalValue,order.time));
            long idTransaction = CallApi.PostRequest(TRANS_DATA, URL_TRANS);
            if (idTransaction == -1)
                return BadRequest("Não foi possível criar transação");

            long idCreated =  _OrderBusiness.createOrder(order);

            string AUDITS_DATA = JsonConvert.SerializeObject(new Record(order.userName, order.store, order.time, order.totalValue, order.location));
            long idAudit = CallApi.PostRequest(AUDITS_DATA, URL_AUDIT);
            if (idAudit == -1)
                return BadRequest("Não foi possível registrar operação");

            return idCreated;
        }
        [HttpGet("{orderId}")]
        public ActionResult<Order> Get(long orderId)
        {
            return _OrderBusiness.getOrder(orderId);
        }
    }
}
