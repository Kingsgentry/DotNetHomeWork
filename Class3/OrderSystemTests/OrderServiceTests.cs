using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderSystem;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderSystem.Tests
{
    [TestClass]
    public class OrderServiceTests
    {
        private List<Order> CreateTestList1()
        {
            OrderDetails commodity1 = new OrderDetails("apple", 5.99f, 5);
            OrderDetails commodity2 = new OrderDetails("banana", 3.99f, 1);
            OrderDetails commodity3 = new OrderDetails("orange", 4.99f, 2);
            OrderDetails commodity4 = new OrderDetails("lemon", 6.99f, 3);

            List<OrderDetails> orderDetails1 = new List<OrderDetails>();
            orderDetails1.Add(commodity1);

            List<OrderDetails> orderDetails2 = new List<OrderDetails>();
            orderDetails2.Add(commodity2);

            List<OrderDetails> orderDetails3 = new List<OrderDetails>();
            orderDetails1.Add(commodity3);
            orderDetails3.Add(commodity4);



            Order order1 = new Order(1, "Chen", "Wuhan", orderDetails1);
            Order order2 = new Order(2, "Navon", "Wuhan", orderDetails2);
            Order order3 = new Order(3, "Chen", "Beijing", orderDetails3);

            List<Order> orderList = new List<Order>();

            orderList.Add(order1);
            orderList.Add(order2);
            orderList.Add(order3);

            return orderList;

        }
        [TestMethod]
        public void SelectOrderByIdTest()
        {
            List<Order> orderList = CreateTestList1();

            OrderService orderService = new OrderService(orderList);
            Order order1 = orderService.SelectOrderById(1);
            Order order2 = orderService.SelectOrderById(2);
            Assert.AreSame(order1, orderList[0]);
        }

        [TestMethod]
        public void SelectOrderByCustomerTest()
        {
            List<Order> orderList = CreateTestList1();

            OrderService orderService = new OrderService(orderList);
            List<Order> order1 = orderService.SelectOrderByCustomer("Chen");

            Assert.IsNotNull(order1);

        }

        [TestMethod]
        public void SelectOrderByAddressTest()
        {
            List<Order> orderList = CreateTestList1();

            OrderService orderService = new OrderService(orderList);
            List<Order> order1 = orderService.SelectOrderByAddress("Wuhan");

            Assert.IsNotNull(order1);
        }

        /*
        [TestMethod()]
        public void AddTest()
        {
            List<Order> orderList = CreateTestList1();

            OrderService orderService = new OrderService(orderList);
            Order order = new Order(1, "Chen", "Wuhan", null);
            //List<Order> order1 = orderService.Add(order);

            Assert.IsNotNull(order1);
        }*/
    }
}