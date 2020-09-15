using System;
using System.Collections.Generic;

namespace FactoryPattern
{
    public enum ShapeType
    { 
        Square,
        Retangle,
        Triangle
    }
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory factory = new ShapeFactory();
            List<Shape> shapes = new List<Shape>();
            shapes.Add(factory.CreateShape(ShapeType.Square, 1));
            shapes.Add(factory.CreateShape(ShapeType.Retangle, 2, -1));
            shapes.Add(factory.CreateShape(ShapeType.Triangle, 3, 4, 5));
            foreach (Shape temp in shapes)
            {
                if (temp.IsLegal)
                {
                    Console.WriteLine(temp.GetType().ToString() + "'s area is: " + temp.CaculateArea()); 
                }
            }
        }
    }

    public class ShapeFactory
    {
        public Shape CreateShape(ShapeType type, params float[] inputs)
        {
            try
            {
                switch (type)
                {
                    case ShapeType.Square:
                        {
                            return new Square(inputs[0]);
                        }
                    case ShapeType.Retangle:
                        {
                            return new Retangle(inputs[0], inputs[1]);
                        }
                    case ShapeType.Triangle:
                        {
                            return new Triangle(inputs[0], inputs[1], inputs[2]);
                        }
                    default:
                        {
                            return null;
                        }

                }
            }
            catch
            {
                Console.WriteLine("Input Error");
                return null;
            }
            
        }
    }


}
