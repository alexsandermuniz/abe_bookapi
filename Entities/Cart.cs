using System;
using System.Collections.Generic;

public class Cart{
    public long id   {get;set;}
    public List<Book> books {get;set;}
    public Cart(List<Book> books)
    {
        this.books = books;
    }

}