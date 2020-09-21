using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Xml.Serialization;

namespace OrderSystem
{

    public class OrderService
    {
        private List<Order> orderList;

        public OrderService(List<Order> orderList)
        {
            this.orderList = orderList;
            orderList.Sort((p1, p2) => p1.ID - p2.ID);
        }

        public OrderService(string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                orderList = (List<Order>)xmlSerializer.Deserialize(fs);
            }
        }

        #region Add
        public void Add(Order order)
        {
            if (orderList.Contains(order))
                throw new Exception("input repetitive order");
            orderList.Add(order);
            orderList.Sort((p1, p2) => p1.ID - p2.ID);
        }

        #endregion

        #region Select
        public Order SelectOrderById(int id)
        {
            return orderList.SingleOrDefault(target => target.ID == id);
        }

        public List<Order> SelectOrderByCustomer(string customer)
        {
            List<Order> resultList = orderList.Where(target => target.Customer == customer).ToList();
            resultList.Sort();
            return resultList;
        }

        public List<Order> SelectOrderByAddress(string address)
        {
            List<Order> resultList = orderList.Where(target => target.Address == address).ToList();
            resultList.Sort();
            return resultList;
        }
        #endregion

        #region Change

        public bool ChangeCommodityNumber(Order order,string commodity, int number)
        {
            if (!order.OrderDetailsDic.ContainsKey(commodity))
            {
                Console.WriteLine("order didn't hold commodity: " + commodity);
                return false;
            }

            if (number <= 0)
            {
                Console.WriteLine("delete order detail: " + commodity);
                DeleteCommodity(order, commodity);
                return false;
            }

            order.OrderDetailsDic[commodity].ChangeNumber(number);
            return true;
        }

        public bool DeleteCommodity(Order order, string commodity)
        {

            if (!order.OrderDetailsDic.ContainsKey(commodity))
            {
                Console.WriteLine("order didn't hold commodity: " + commodity);
                return false;
            }

            order.OrderDetailsDic.Remove(commodity);
            return true;
        }

        #endregion

        #region Delete

        public bool DeleteOrder(Order order)
        {
            if (orderList.Contains(order))
            {
                orderList.Remove(order);
                return true;
            }
            else
            {
                Console.WriteLine("Can't find target order: " + order.ID);
                return false;
            }
        }

        #endregion

        public void CustomizedSort(Comparison<Order> comparison)
        {
            orderList.Sort(comparison);
        }

        public void Export()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream("test.xml", FileMode.Create, FileAccess.Write))
            {
                    xmlSerializer.Serialize(fs, orderList);
                
            }
        }


    }
}
