using System;
using System.Collections.Generic;

public class Order{
    public long id;
    public long cartId;
    public decimal totalValue;
    public decimal totalDisccount;
    public DateTime time;
    public string store;
    public string userName;
    public string location;

    public Order(){}

}