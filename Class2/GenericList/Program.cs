using System;
using System.Collections.Generic;

namespace GenericList
{
    class Program
    {
        static void Main()
        {
            GenericList<int> intlist = new GenericList<int>();
            for (int i = 0; i < 10; i++)
            {
                intlist.Add(i);
            }

            intlist.ForEach(i => Console.WriteLine(i.ToString()));
            int maxCounter = int.MinValue;
            intlist.ForEach(i => {
                if (i >= maxCounter)
                {
                    maxCounter = i;
                }
            }, ref maxCounter);
            Console.WriteLine("Max: " + maxCounter.ToString());

            int minCounter = int.MaxValue;
            intlist.ForEach(i => {
                if (i <= minCounter)
                {
                    minCounter = i;
                }
            }, ref minCounter);
            Console.WriteLine("Min: " + minCounter.ToString());

            int counter = 0;
            intlist.ForEach(i => {
                counter += i;
            }, ref minCounter);
            Console.WriteLine("Sum: " + counter.ToString());
        }
    }

    public class Node<T>
    { 
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }

    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            tail = head = null;
        }

        public Node<T> Head
        {
            get => head;
        }

        public void Add(T t) 
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }

        public int ForEach(Action<T> action)
        {
            for (Node<T> node = this.Head; node != null; node = node.Next)
            {
                action(node.Data);
            }
            return 0;
        }

        public void ForEach(Action<T> action, ref int counter)
        {
            for (Node<T> node = this.Head; node != null; node = node.Next)
            {
                action(node.Data);
            }
        }

    }
}
