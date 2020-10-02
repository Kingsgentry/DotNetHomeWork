using System;
using System.Collections.Generic;
using System.Text;

namespace OrderSystem
{
    [Serializable]
    public class OrderDetails
    {
        public OrderDetails(string name, float singlePrice, int number)
        {
            this.name = name;
            this.singlePrice = singlePrice;
            this.number = number;
        }
        //the name of commodity
        private string name;
        public string Name { get { return name; } }

        //single price of commodity
        private float singlePrice;
        public float SinglePrice { get { return singlePrice; } }

        //number of commodity
        private int number;
        public int Number { get { return number; } }

        //adjust number
        public void ChangeNumber(int num)
        {
            number = num;
        }

        public void ChangeSinglePrice(float price)
        {
            singlePrice = price;
        }

        public void ChangeName(string name)
        {
            this.name = name;
        }

        public OrderDetails Clone()
        {
            return new OrderDetails(this.name, this.singlePrice, this.number);
        }

        public override bool Equals(object obj)
        {
            OrderDetails temp = obj as OrderDetails;
            return temp != null && temp.Name == this.name && temp.SinglePrice == this.singlePrice;
        }

        public override int GetHashCode()
        {
            Random random = new Random();
            return name.GetHashCode() * random.Next(1,100) ;
        }

        public override string ToString()
        {
            return name + ": " + singlePrice.ToString() + "$, " + number.ToString();
        }

    }
}
