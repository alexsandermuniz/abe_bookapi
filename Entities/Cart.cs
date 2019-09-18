using System;
using System.Collections.Generic;

public class Cart{
    long id;
    public List<Book> books {get;set;}
    public Cart(List<Book> books)
    {
        this.books = books;
    }

}