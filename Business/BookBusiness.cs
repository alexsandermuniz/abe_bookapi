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
        List<Comment> commentsMock = new List<Comment>();
        public long addBook(Book book)
        {
            book.id = contMockId;
            booksMock.Add(book);
            return contMockId++;
        }

        public void addComment(Comment comment)
        {
            commentsMock.Add(comment);
        }
    }

}


