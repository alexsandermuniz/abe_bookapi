using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreApi.Business
{
    
    public class CartBusiness
    {
        long contMockId = 100;
        List<Cart> cartsMock = new List<Cart>();
        List<Order> ordersMock = new List<Order>();
        public long addCart(Cart cart)
        {
            cart.id = contMockId;
            cartsMock.Add(cart);
            return contMockId++;
        }
        public void addBooksToCart(long cartId,Book[] books)
        {
            Cart cart = cartsMock.Where(x => x.id == cartId).FirstOrDefault();
            cart.books.AddRange(books.ToList());
        }

        public void createOrder(Order order)
        {
            ordersMock.Add(order);
        }

        public void removeBookFromCart(long cartId,long bookId)
        {
            Cart cart = cartsMock.Where(x => x.id == cartId).FirstOrDefault();
            cart.books.RemoveAll(x => x.id == bookId);
        }
    }

}