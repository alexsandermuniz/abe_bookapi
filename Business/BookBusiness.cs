using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreApi.Business
{
    
    public class BooksBusiness
    {
        long contMockId = 100;
        List<Book> booksMock = new List<Book>();
        public long addBook(Book book)
        {
            booksMock.Add(book);
            return contMockId++;
        }
    }

}


