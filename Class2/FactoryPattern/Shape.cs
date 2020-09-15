using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public abstract class Shape
    {
        public bool IsLegal { get; }
        public Shape(params float[] inputs)
        {
            if (!IsValid(inputs))
            {
                Console.WriteLine("Shape input is invalid");
                this.IsLegal = false;
            }
            else
                this.IsLegal = true;


        }

        public abstract float CaculateArea();

        protected abstract bool IsValid(float[] inputs);

    }

    public class Square : Shape
    {
        private float length;

        public Square(float lengthInput) : base(lengthInput)
        {
            this.length = lengthInput;
        }

        public override float CaculateArea()
        {
            return MathF.Sqrt(length);
        }

        protected override bool IsValid(float[] inputs)
        {
            try
            {
                return inputs[0] > 0;
            }
            catch
            {
                return false;
            }
        }


    }

    public class Retangle : Shape
    {
        private float width;
        private float length;

        public Retangle(float widthInput, float lengthInput) : base(widthInput, lengthInput)
        {
            width = widthInput;
            length = lengthInput;
        }

        public override float CaculateArea()
        {
            return width * length;
        }

        protected override bool IsValid(float[] inputs)
        {
            try
            {
                return inputs[0] > 0 && inputs[1] > 0;
            }
            catch
            {
                return false;
            }

        }
    }

    public class Triangle : Shape
    {
        private float edge1;
        private float edge2;
        private float edge3;

        public Triangle(float edgeInput1, float edgeInput2, float edgeInput3) : base(edgeInput1, edgeInput2, edgeInput3)
        {
            edge1 = edgeInput1;
            edge2 = edgeInput2;
            edge3 = edgeInput3;
        }

        public override float CaculateArea()
        {
            float p = (edge1 + edge2 + edge3) / 2;
            return MathF.Sqrt(p * (p - edge1) * (p - edge2) * (p - edge3));
        }

        protected override bool IsValid(float[] inputs)
        {
            try
            {
                return inputs[0] + inputs[1] > inputs[2] && inputs[1] + inputs[2] > inputs[0] && inputs[0] + inputs[2] > inputs[1];
            }
            catch
            {
                return false;
            }
        }
    }
}
