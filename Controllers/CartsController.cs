using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BookStoreApi.Business;

namespace BookStoreApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CartsController : ControllerBase
    {
        CartBusiness _CartBusiness = new CartBusiness();
        // POST api/carts
        [HttpPost]
        public ActionResult<long>  Post([FromBody] Cart cart)
        {
           return _CartBusiness.addCart(cart);         
        }
        // POST api/carts/{cartId}/books
        [HttpPost("{cartId}/books")]
        public ActionResult<long>  Post(long cartId,[FromBody] Book[] books)
        {
            _CartBusiness.addBooksToCart(cartId, books);
            return Ok();      
        }
        // DELETE api/carts/{cartId}/books/{bookId}
        [HttpDelete("{cartId}/books/{bookId}")]
        public void Delete(long cartId,long bookId)
        {
            _CartBusiness.removeBookFromCart(cartId, bookId);           
        }        
        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
