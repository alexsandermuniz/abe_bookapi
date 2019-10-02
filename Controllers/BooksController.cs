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
           _BookBusiness.addComment(comment);
            return Ok();
        }        
    }
}
