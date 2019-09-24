using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreApi.Business
{
    
    public class OrderBusiness
    {
        long contMockId = 100;
        List<Order> ordersMock = new List<Order>();

        public long createOrder(Order order)
        {
            order.id = contMockId;
            ordersMock.Add(order);
            return contMockId++;        
        }

        public Order getOrder(long id)
        {
            return ordersMock.Where(x => x.id == id).FirstOrDefault();
        }
    }

}