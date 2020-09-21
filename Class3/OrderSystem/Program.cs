using System;
using System.Collections.Generic;

namespace OrderSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderDetails detail1 = new OrderDetails("apple", 8.99f, 5);
            OrderDetails detail2 = new OrderDetails("banana", 5.99f, 2);
            List<OrderDetails> orderDetailsList = new List<OrderDetails>();
            orderDetailsList.Add(detail1);
            orderDetailsList.Add(detail2);
            Order order = new Order(1, "lalala", "lalal", orderDetailsList);
            
            if (!detail1.Equals(detail2))
            {
                Console.WriteLine(detail1.GetHashCode().ToString());
                Console.WriteLine(detail2.GetHashCode().ToString());
            }
                
            
        }
    }
}
