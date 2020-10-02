using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Linq;


namespace OrderSystem
{

    [Serializable]
    public class Order : IComparable
    {
        public static void Main()
        { 
        
        }
        public Order(int id, string customer, string address, List<OrderDetails> orderDetails)
        {
            this.id = id;
            this.address = address;
            this.customer = customer;
            this.OrderDetailsDic = new Dictionary<string, OrderDetails>();
            if (orderDetails.Count > 0)
            {
                foreach (OrderDetails temp in orderDetails)
                {
                    if (this.OrderDetailsDic.ContainsKey(temp.Name))
                    {
                        Console.WriteLine("Input repetitive order detail");
                        return;
                    }

                    this.OrderDetailsDic.Add(temp.Name, temp.Clone());
                }
            }
            
        }

        //Order ID
        private readonly int id;
        public int ID { get { return this.id; } }

        // customer's name
        private string customer;
        public string Customer { get { return this.customer; } }

        //address
        private string address;
        public string Address { get { return this.address; } }

        // total price
        public float Price
        {
            get
            {
                float counter = 0;
                foreach (OrderDetails temp in this.OrderDetailsDic.Values)
                {
                    counter += temp.Number * temp.SinglePrice;
                }
                return counter;
            }
        }

        public Dictionary<string, OrderDetails> OrderDetailsDic;

        /* -------------------Method---------------------------------*/

        public void ChangeAddress(string newAddress)
        {
            this.address = newAddress;
        }

        public void ChangeCustomer(string newCustomer)
        {
            this.customer = newCustomer;
        }


        public override bool Equals(object obj)
        {
            Order order = obj as Order;
            return order != null && order.id == this.id;
        }


        public override int GetHashCode()
        {
            return this.id;
        }

        public override string ToString()
        {
            return "Order " + id.ToString() + ": " + customer + ", " + address + ", " + Price + "$";
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Order))
                throw new NotImplementedException();
            Order order = obj as Order;
            return (int)(this.Price - order.Price);
        }
    }
}
