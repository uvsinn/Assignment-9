using System;

namespace Assignment9
{
    abstract class Shape
    {
        protected int area;
        public abstract void GetDimensions();
        public abstract void CalculateArea();
        public void DisplayArea()
        {
            Console.WriteLine("Area is " + area);
        }
    }
    class Square : Shape
    {
        int side;

        public override void CalculateArea()
        {
            area = side * side;
        }

        public override void GetDimensions()
        {
            Console.WriteLine("Enter side");
            side = Byte.Parse(Console.ReadLine());
        }
    }
    class Rectangle : Shape
    {
        int length, breadth;

        public override void GetDimensions()
        {
            Console.WriteLine("Enter length");
            length = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter breadth");
            breadth = Byte.Parse(Console.ReadLine());
        }
        public override void CalculateArea()
        {
            area = length * breadth;
        }


    }


    internal class Program
    {
        static void Main(string[] args)
        {

            Shape shape = null;
            Console.WriteLine("Enter shape type");
            int c = Byte.Parse(Console.ReadLine());
            if (c == 1)
            {
                shape = new Square();

            }
            else if (c == 2)
            {
                shape = new Rectangle();

            }
            CheckShape checkShape = new CheckShape();
            checkShape.Checkshape(shape);
        }
    }

    class CheckShape
    {
        public void Checkshape(Shape shape)
        {
            if (shape is Square)
            {
                shape = (Square)shape;

            }
            else if (shape is Rectangle)
            {
                shape = (Rectangle)shape;

            }
            shape.GetDimensions();
            shape.CalculateArea();
            shape.DisplayArea();
        }
    }
}