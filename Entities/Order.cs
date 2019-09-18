using System;
using System.Collections.Generic;

public class Order{
    public long id;
    public Cart cart;
    public decimal totalValue;
    public decimal totalDisccount;
    public DateTime time;

    public Order(Cart cart)
    {
        this.cart = cart;
    }

}