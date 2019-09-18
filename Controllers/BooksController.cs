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
    public class BooksController : ControllerBase
    {
        BooksBusiness _BookBusiness = new BooksBusiness();
        // POST api/books
        [HttpPost]
        public ActionResult<long>  Post([FromBody] Book book)
        {
           return _BookBusiness.addBook(book);         
        }

        // POST api/books/{bookId}/comments
        [HttpPost("{bookId}/comments")]
        public ActionResult<long>  Post([FromBody] Comment comment)
        {
           return _BookBusiness.addComment();         
        }




        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
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
